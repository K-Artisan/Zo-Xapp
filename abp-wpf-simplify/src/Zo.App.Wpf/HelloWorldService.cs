﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Zo.App.Wpf
{
    public class HelloWorldService : ITransientDependency
    {
        public string SayHello()
        {
            return "Hello world!";
        }
    }
}
