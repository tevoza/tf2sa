using TF2SA.Data;

namespace TF2SA.StatsETLService
{
    public static class DependencyInjection
    {
        public static void AddStatsETLService(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDataLayer(configuration);
            services.AddHostedService<StatsETLServiceRunner>();
            services.AddScoped<IStatsETLService, StatsETLService>();
        }
    }
}