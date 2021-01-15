using System;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;
using Zo.App.Application.Contracts;

namespace Zo.App.Applications
{
    public class DemoAppService  : IDemoAppService, ITransientDependency
    {
        public DemoAppService()
        {
        }

        public string GetInfos()
        {
            return "I'm an App Base On Apb + MahApps.Metro";
        }
    }
}
