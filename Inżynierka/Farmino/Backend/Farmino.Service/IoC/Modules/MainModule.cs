﻿using Autofac;

namespace Farmino.Service.IoC.Modules
{
    public class MainModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<ServiceModule>();
            builder.RegisterModule<CommandsModule>();
            builder.RegisterModule<QueryModule>();
            builder.RegisterModule<RepositoryModule>();
            builder.RegisterModule<SecurityModule>();
        }
    }
}
