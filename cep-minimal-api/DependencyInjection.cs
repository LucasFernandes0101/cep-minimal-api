using cep_minimal_api.Providers.v1.ViaCep;

namespace cep_minimal_api
{
    public static class DependencyInjection
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddSingleton<ViaCepClient>();

            services.AddHttpClient<ViaCepClient>(client =>
            {
                client.BaseAddress = new Uri(Environment.GetEnvironmentVariable("URL_VIA_CEP_API") ?? "");
            });

            return services;
        }
    }
}
