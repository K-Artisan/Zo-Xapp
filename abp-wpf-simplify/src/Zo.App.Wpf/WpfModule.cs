using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;
using Zo.App.Applications;

namespace Zo.App.Wpf
{
    [DependsOn(typeof(AbpAutofacModule),
        typeof(AppApplicationsModule))]
    public class WpfModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddSingleton<MainWindow>();
        }
    }
}
