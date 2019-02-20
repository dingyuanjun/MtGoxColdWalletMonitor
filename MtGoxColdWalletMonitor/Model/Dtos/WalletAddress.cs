using System;

namespace MtGoxColdWalletMonitor.Model.Dtos
{
     public class WalletAddress
     {
         public int WalletAddressId { get; set; }
         public string Hash160Address { get; set; }
         public decimal? LastKnownBalance { get; set; }
         public DateTime? LastCheckedDateTime { get; set; }
     }
 }