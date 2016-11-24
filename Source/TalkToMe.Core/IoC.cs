using System;
using Autofac;
using TalkToMe.Core.Services.IoC;

namespace TalkToMe.Core
{
    public static class IoC
    {
        public static IContainer Container { get; private set; }

        public static void Initialize(params Func<ContainerBuilder, ContainerBuilder>[] functions)
        {
            var builder = new ContainerBuilder();
            foreach (var func in functions)
            {
                builder = func.Invoke(builder);
            }
            builder = builder.RegisterCommonDependencies();
            Container = builder.Build();
        }
    }
}
