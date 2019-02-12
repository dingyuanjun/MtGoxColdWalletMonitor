using System.Globalization;
using System.Threading.Tasks;
using BlockchainInfoApi;
using Microsoft.AspNetCore.Mvc;

namespace MtGoxColdWalletMonitor.Controllers
{
    [Route("api/[controller]")]
    public class BlockchainDataController : Controller
    {
        private readonly IBlockchainApiClient _blockchainApiClient;

        public BlockchainDataController(IBlockchainApiClient blockchainApiClient)
        {
            _blockchainApiClient = blockchainApiClient;
        }

        [HttpGet("[action]/{address}")]
        public async Task<string> GetBalance(string address)
        {
            var balance = await _blockchainApiClient.GetBalanceAsync(address);

            return balance.ToString(CultureInfo.InvariantCulture);
        }
    }
}