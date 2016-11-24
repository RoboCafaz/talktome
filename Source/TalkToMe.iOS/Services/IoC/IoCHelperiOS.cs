using Autofac;

namespace TalkToMe.iOS.Services.IoC
{
    internal static class IoCHelperiOS
    {
        public static ContainerBuilder RegisteriOSDependencies(this ContainerBuilder builder)
        {
            // Register common IoC dependencies here.
            return builder;
        }
    }
}
