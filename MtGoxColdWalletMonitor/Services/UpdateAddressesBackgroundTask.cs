using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlockchainInfoApi;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MtGoxColdWalletMonitor.Model;
using MtGoxColdWalletMonitor.Model.Dtos;

namespace MtGoxColdWalletMonitor.Services
{
    public class UpdateAddressesBackgroundTask : BackgroundService
    {
        private readonly ILogger<UpdateAddressesBackgroundTask> _logger;
        private readonly IBlockchainApiClient _blockchainApiClient;

        public UpdateAddressesBackgroundTask(ILogger<UpdateAddressesBackgroundTask> logger,
            IBlockchainApiClient blockchainApiClient)
        {
            _logger = logger;
            _blockchainApiClient = blockchainApiClient;
        }
        
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogDebug($"UpdateAddressesBackgroundTask is starting.");
            
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogDebug($"UpdateAddressesBackgroundTask task doing background work.");

                await UpdateMtGoxDbData();
                
                await Task.Delay(TimeSpan.FromHours(1), stoppingToken);
            }
            
            _logger.LogDebug($"UpdateAddressesBackgroundTask is stopping.");
        }

        private async Task UpdateMtGoxDbData()
        {
            using (var context = new MtGoxAddressesContext())
            {
                var addresses = context.WalletAddresses;
                var addressesCount = addresses.Count();
                var idx = 1;
                
                foreach (var address in addresses)
                {
                    _logger.LogDebug($"{idx++}/{addressesCount} - updating addresses info {address.Hash160Address}");

                    var dateNow = DateTime.Now;
                    
                    if (ShouldUpdateAddressInfo(address, dateNow))
                    {
                        try
                        {
                            var addressInfo = await _blockchainApiClient.GetAddressBaseInformation(address.Hash160Address);
                        
                            address.TotalBalance = addressInfo.TotalReceived;
                            address.LastKnownBalance = addressInfo.LastBalance;
                            address.LastOperationDateTime = addressInfo.LastTransaction;
                            address.LastCheckedDateTime = dateNow;
                        }
                        catch (Exception e)
                        {
                            _logger.Log(LogLevel.Error, e, $"Error occured during UpdateMtGoxDbData");
                            throw;
                        }
                    }
                    
                    context.SaveChanges();
                }
            }
        }

        private static bool ShouldUpdateAddressInfo(WalletAddress address, DateTime currentDate)
        {
            return !address.LastCheckedDateTime.HasValue || currentDate - address.LastCheckedDateTime > TimeSpan.FromHours(1);
        }
    }
}