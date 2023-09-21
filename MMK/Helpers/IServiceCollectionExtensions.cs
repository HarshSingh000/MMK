using MMK.Models;
using Microsoft.Extensions.DependencyInjection;

namespace MMK
{
    public static class IServiceCollectionExtensions
    {
        public static void AddMMKServices(this IServiceCollection services)
        {
            AddViewComponentServices(services);
            AddRepositories(services);
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddSingleton<MenuRepository>();
            services.AddSingleton<FaqRepository>();
            services.AddSingleton<GalleryRepository>();
            services.AddSingleton<TeamRepository>();
            services.AddSingleton<ContactRepository>();
            services.AddSingleton<CalendarRepository>();
            services.AddSingleton<DropDownRepository>();
        }

        private static void AddViewComponentServices(IServiceCollection services)
        {
            
        }
    }
}
