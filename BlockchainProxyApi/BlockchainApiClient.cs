using System;
using System.Threading.Tasks;
using Info.Blockchain.API.BlockExplorer;
using Info.Blockchain.API.Client;
using Info.Blockchain.API.Models;

namespace BlockchainInfoApi
{
    public interface IBlockchainApiClient
    {
        Task<decimal> GetBalanceAsync(string address160);
        Task<DateTime?> GetLastTransactionDateAsync(string address160);
    }
    
    public class BlockchainApiClient : IBlockchainApiClient
    {
        private readonly BlockExplorer _blockExplorer;
        private readonly decimal _threshold;

        public BlockchainApiClient(BlockExplorer blockExplorer, decimal threshold)
        {
            _blockExplorer = blockExplorer;
            _threshold = threshold;
        }

        public async Task<decimal> GetBalanceAsync(string address160)
        {
            var address = await _blockExplorer.GetHash160AddressAsync(address160);

            return address.FinalBalance.GetBtc();
        }

        private async Task<decimal> GetResultOfTransaction(string transactionHash, string againstAddress)
        {
            using (var client = new BlockchainHttpClient())
            {
                var result = await client.GetAsync<long>($"q/txresult/{transactionHash}/{againstAddress}");

                return BitcoinValue.FromSatoshis(result).GetBtc();
            }
        }
        
        public async Task<DateTime?> GetLastTransactionDateAsync(string address160)
        {
            var address = await _blockExplorer.GetHash160AddressAsync(address160);

            foreach (var transaction in address.Transactions)
            {
                var result = await GetResultOfTransaction(transaction.Hash, address160);

                if (Math.Abs(result) > _threshold)
                {
                    return transaction.Time;
                }
            }

            return null;
        }
    }
}