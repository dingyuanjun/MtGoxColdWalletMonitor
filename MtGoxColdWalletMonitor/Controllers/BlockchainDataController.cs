using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using BlockchainInfoApi;
using Microsoft.AspNetCore.Mvc;
using MtGoxColdWalletMonitor.Controllers.Dtos;
using MtGoxColdWalletMonitor.Services;

namespace MtGoxColdWalletMonitor.Controllers
{
    [Route("api/[controller]")]
    public class BlockchainDataController : Controller
    {
        private readonly IBlockchainApiClient _blockchainApiClient;
        private readonly IMtGoxAddressesFetcher _mtGoxAddressesFetcher;

        public BlockchainDataController(IBlockchainApiClient blockchainApiClient,
            IMtGoxAddressesFetcher mtGoxAddressesFetcher)
        {
            _blockchainApiClient = blockchainApiClient;
            _mtGoxAddressesFetcher = mtGoxAddressesFetcher;
        }

        [HttpGet("[action]/{address}")]
        public async Task<string> GetBalance(string address)
        {
            var balance = await _blockchainApiClient.GetBalanceAsync(address);

            return balance.ToString(CultureInfo.InvariantCulture);
        }
        
        [HttpGet("[action]")]
        public async Task<List<WalletWithBalance>> GetLastKnownBalancesOfMtGoxAddresses()
        {
            var balances = await _mtGoxAddressesFetcher.GetListOfMtGoxWalletsWithBalances();

            return balances;
        }
        
        [HttpGet("[action]/{address}")]
        public async Task<DateTime?> GetLastOperationDate(string address)
        {
            var lastOperationDate = await _blockchainApiClient.GetLastTransactionDateAsync(address);

            return lastOperationDate;
        }
    }
}