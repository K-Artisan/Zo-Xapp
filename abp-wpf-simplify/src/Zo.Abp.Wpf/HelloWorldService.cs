using Volo.Abp.DependencyInjection;

 namespace Zo.Abp.Wpf
{
    public class HelloWorldService : ITransientDependency
    {
        public string SayHello()
        {
            return "Hello world!";
        }
    }
}
