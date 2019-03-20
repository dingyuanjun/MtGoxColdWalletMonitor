using Microsoft.Extensions.DependencyInjection;
using Info.Blockchain.API.BlockExplorer;
using Info.Blockchain.API.Client;

namespace BlockchainInfoApi
{
    public static class BlockchainProxyApiConfiguration
    {
        public static IServiceCollection RegisterBlockchainApiClient(this IServiceCollection services, decimal threshold = 0)
        {
            services.AddSingleton<BlockchainHttpClient>();
            services.AddSingleton<BlockExplorer>();
            services.AddScoped<IBlockchainApiClient>(s => new BlockchainApiClient(s.GetService<BlockExplorer>(), threshold));
            
            return services;
        }
    }
}