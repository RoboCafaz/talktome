using Autofac;

namespace TalkToMe.Core.Services.IoC
{
    internal static class IoCHelper
    {
        public static ContainerBuilder RegisterCommonDependencies(this ContainerBuilder builder)
        {
            // Register common IoC dependencies here.
            return builder;
        }
    }
}
