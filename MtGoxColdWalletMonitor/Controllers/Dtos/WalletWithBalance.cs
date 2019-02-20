namespace MtGoxColdWalletMonitor.Controllers.Dtos
{
    public class WalletWithBalance
    {
        public string Address { get; set; }
        public decimal? LastKnownBalance { get; set; }
    }
}