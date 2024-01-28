using ClassLibrary1;
using Microsoft.Extensions.DependencyInjection;
using vbinterfaces;

namespace TestProject1
{
    public static class Helper
    {
        private static ServiceProvider Provider => new ServiceCollection()
                .AddSingleton<IClass1, Class1>()
                .BuildServiceProvider();

        public static T GetRequiredService<T>() where T : notnull
        {
            return Provider.GetRequiredService<T>();
        }
    }
}
