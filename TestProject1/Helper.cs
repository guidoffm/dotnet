using ClassLibrary1;
using Microsoft.Extensions.DependencyInjection;
using vbinterfaces;

namespace TestProject1
{
    public static class Helper
    {
        private static IServiceProvider Provider()
        {
            return new ServiceCollection()
                .AddSingleton<IClass1, Class1>()
                .BuildServiceProvider();
        }

        public static T GetRequiredService<T>() where T : notnull
        {
            var provider = Provider();
            return provider.GetRequiredService<T>();
        }
    }
}
