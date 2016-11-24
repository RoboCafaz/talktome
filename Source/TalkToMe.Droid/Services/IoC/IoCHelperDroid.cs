using Autofac;

namespace TalkToMe.Droid.Services.IoC
{
    internal static class IoCHelperDroid
    {
        public static ContainerBuilder RegisterDroidDependencies(this ContainerBuilder builder)
        {
            // Register common IoC dependencies here.
            return builder;
        }
    }
}
