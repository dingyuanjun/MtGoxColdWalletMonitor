using Microsoft.Extensions.DependencyInjection;
using Info.Blockchain.API.BlockExplorer;
using Info.Blockchain.API.Client;

namespace BlockchainInfoApi
{
    public static class BlockchainProxyApiConfiguration
    {
        
        public static IServiceCollection RegisterBlockchainInfoAsProvider(this IServiceCollection services)
        {
            services.AddSingleton<BlockchainHttpClient>();
            services.AddSingleton<BlockExplorer>();
            return services;
        }
    }
}