using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zo.App.Wpf
{
    public class UserService : IUserService
    {
        public string GetName()
        {
            return "I'm an App Base On Apb + MahApps.Metro";
        }
    }
}
