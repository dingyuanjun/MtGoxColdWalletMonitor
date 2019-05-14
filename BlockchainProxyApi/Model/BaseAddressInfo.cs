using System;

namespace BlockchainInfoApi.Model
{
    public class BaseAddressInfo
    {
        public DateTime? LastTransaction { get; set; }
        public decimal TotalReceived { get; set; }
        public decimal LastBalance { get; set; }
    }
}