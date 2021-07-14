using fm.Common.AutomapperProfiles;
using fm.Interfaces.Repositories;
using fm.Interfaces.Services;
using fm.Repository.Repository;
using fm.Services.EntityFramework;
using Microsoft.Extensions.DependencyInjection;

namespace fm.Common
{
    public class DependencyInjector
    {
        public static void ConfigureAll(IServiceCollection services)
        {
            ConfigureRepository(services);
            ConfigureServices(services);
        }

        public static void ConfigureRepository(IServiceCollection services)
        {
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            services.AddScoped<ICurrencyRepository, CurrencyRepository>();
            services.AddScoped<ITransactionTypeRepository, TransactionTypeRepository>();
            services.AddScoped<ITransactionCategoryRepository, TransactionCategoryRepository>();
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ITransactionService, TransactionService>();
            services.AddScoped<ICurrencyService, CurrencyService>();
            services.AddScoped<ITransactionTypeService, TransactionTypeService>();
            services.AddScoped<ITransactionCategoryService, TransactionCategoryService>();
        }

        public static void UpdateAutoMapperConfiguration(AutoMapper.IMapperConfigurationExpression cfg)
        {
            cfg.AddProfile<CurrencyToModelProfile>();
            cfg.AddProfile<TransactionCategoryToModelProfile>();
            cfg.AddProfile<TransactionToModelProfile>();
            cfg.AddProfile<TransactionTypeToModelProfile>();
        }
    }
}
