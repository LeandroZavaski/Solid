using Dip.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace Dip.Factory
{
    public class DbProductFactory
    {
        public static IConfigurationRoot configuration;

        public static IDbProduct Create()
        {
            ServiceCollection serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            if (configuration.GetConnectionString("DataConnection") == "SQLSERVER")
            {
                return new SqlServerProduct();
            }
            else
            {
                return new MongoDbProduct();
            }
        }

        private static void ConfigureServices(IServiceCollection serviceCollection)
        {
            // Build configuration
            configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("appsettings.json", false)
                .Build();

            // Add access to generic IConfigurationRoot
            serviceCollection.AddSingleton<IConfigurationRoot>(configuration);
        }
    }
}
