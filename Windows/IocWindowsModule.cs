﻿using Autofac;

namespace SampleApplication.Windows
{
    public class IocWindowsModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<WindowsDatabaseConnectionFactory>().As<IDatabaseConnectionFactory>().AsSelf();
        }
    }
}