using System.Threading.Tasks;
using Info.Blockchain.API.BlockExplorer;

namespace BlockchainInfoApi
{
    public interface IBlockchainApiClient
    {
        Task<decimal> GetBalanceAsync(string address160);
    }
    
    public class BlockchainApiClient : IBlockchainApiClient
    {
        private readonly BlockExplorer _blockExplorer;

        public BlockchainApiClient(BlockExplorer blockExplorer)
        {
            _blockExplorer = blockExplorer;
        }

        public async Task<decimal> GetBalanceAsync(string address160)
        {
            var address = await _blockExplorer.GetHash160AddressAsync(address160);

            return address.FinalBalance.GetBtc();
        }
    }
}