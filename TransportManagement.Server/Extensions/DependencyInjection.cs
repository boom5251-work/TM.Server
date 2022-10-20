using Microsoft.EntityFrameworkCore;
using TransportManagement.Server.DAL.Context;

namespace TransportManagement.Server.Extensions
{
    /// <summary>
    /// Внедрение пользовательских зависимостей.
    /// </summary>
    public static class DependencyInjection
    {
        /// <summary>
        /// Внедряет все пользовательские зависимости (сервисы).
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configManager">Конфигурация приложения.</param>
        public static void AddCustomServices(this IServiceCollection services, ConfigurationManager configManager)
        {
            AddDbContext(services, configManager);

            AddTransient(services);
            AddScoped(services);
            AddSingleton(services);
        }


        /// <summary>
        /// Добавляет контекст базы данных к сервисам приложения.
        /// </summary>
        /// <param name="services">Набор сервисов приложения.</param>
        /// <param name="configManager">Менеджер конфигурации приложения.</param>
        private static void AddDbContext(IServiceCollection services, ConfigurationManager configManager)
        {
            services.AddDbContext<IDatabaseContext, DatabaseContext>((DbContextOptionsBuilder optionsBuilder) =>
            {
                string connectionString = configManager.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            });
        }


        /// <summary>
        /// Добавление недолговечный сервисов.
        /// </summary>
        /// <param name="services">Набор сервисов приложения.</param>
        private static void AddTransient(IServiceCollection services)
        {
            return;
        }


        /// <summary>
        /// добавление зависимостей с областью действия.
        /// </summary>
        /// <param name="services">Набор сервисов приложения.</param>
        private static void AddScoped(IServiceCollection services)
        {
            return;
        }


        /// <summary>
        /// Добавление сервисов-одиночек.
        /// </summary>
        /// <param name="services">Набор сервисов приложения.</param>
        private static void AddSingleton(IServiceCollection services)
        {
            return;
        }
    }
}