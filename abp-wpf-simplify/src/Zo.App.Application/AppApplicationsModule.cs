using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Modularity;
using Zo.App.Application.Contracts;

namespace Zo.App.Applications
{
    [DependsOn(
        typeof(AppApplicationContractsModule)
        )]
    public class AppApplicationsModule :AbpModule
    {
    }
}
