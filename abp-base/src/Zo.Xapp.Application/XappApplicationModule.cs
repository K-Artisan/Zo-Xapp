using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace Zo.Xapp
{
    [DependsOn(
        typeof(XappDomainModule),
        typeof(XappApplicationContractsModule)
        )]
    public class XappApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<XappApplicationModule>();
            });
        }
    }
}
