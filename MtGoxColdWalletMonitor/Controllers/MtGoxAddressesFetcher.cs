using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MtGoxColdWalletMonitor.Controllers.Dtos;
using MtGoxColdWalletMonitor.Model;

namespace MtGoxColdWalletMonitor.Controllers
{
    public interface IMtGoxAddressesFetcher
    {
        Task<List<WalletWithBalance>> GetListOfMtGoxWalletsWithBalances();
    }
    
    public class MtGoxAddressesFetcher : IMtGoxAddressesFetcher
    {
        public Task<List<WalletWithBalance>> GetListOfMtGoxWalletsWithBalances()
        {
            using (var context = new MtGoxAddressesContext())
            {
                return context.WalletAddresses
                    .Select(address => new WalletWithBalance
                    {
                        Address = address.Hash160Address,
                        LastKnownBalance = address.LastKnownBalance,
                    })
                    .ToListAsync();
            }
        }
    }
}