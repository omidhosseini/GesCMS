namespace GesCMS.Common.IocConfig
{
    public static class GesCMSServiceRegistry
    {

        public static IServiceCollection AddGesConfigurationServices(
            this IServiceCollection services
        )
        {
            // Register Configuration Services...

            services.Configure<DbSettings>(Configuration.GetSection("ConnectionStrings"));
        }
        
    }
}