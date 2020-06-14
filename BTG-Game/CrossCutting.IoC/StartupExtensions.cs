using Application.Interfaces;
using Application.Services;
using CrossCutting.Adapter.Interfaces;
using CrossCutting.Adapter.Mappers;
using Data.Context;
using Data.Repositories;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CrossCutting.IoC
{
    public static class StartupExtensions
    {
        public static void AddDefaultServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("BtgDB")));
            services.AddTransient<DataContext, DataContext>();

            services.AddTransient<IHistoryRepository, HistoryRepository>();
            services.AddTransient<IHistoryService, HistoryService>();
            services.AddTransient<IHistoryAppService, HistoryAppService>();
            services.AddTransient<IHistoryMapper, HistoryMapper>();
        }
        public static void UseDatabaseMigrations(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<DataContext>();
                context.Database.Migrate();
            }
        }
    }
}
