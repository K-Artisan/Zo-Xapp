using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Zo.App.Wpf
{
    public interface IUserService: ITransientDependency
    {
        string GetName();
    }
}
