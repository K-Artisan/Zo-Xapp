using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;
using Zo.App.Applications;

namespace Zo.Abp.Wpf
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AppApplicationsModule)
        )]
    public class WpfModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddSingleton<MainWindow>();
        }
    }
}
