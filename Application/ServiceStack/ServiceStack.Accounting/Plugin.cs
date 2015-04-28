﻿using Demo.Library.Queries;
using ServiceStack;

using ServiceStack.Validation;
using SimpleInjector.Extensions;
using System.Linq;

namespace Demo.Application.ServiceStack.Accounting
{
    public class Plugin : IPlugin
    {
        public void Register(IAppHost appHost)
        {
            appHost.RegisterService<Account.Service>();
            appHost.RegisterService<Currency.Service>();
            appHost.RegisterService<FiscalYear.Service>();
            appHost.RegisterService<FiscalYear.Entities.Period.Service>();
            appHost.RegisterService<Journal.Service>();
            appHost.RegisterService<Journal.Entities.Entry.Service>();
            appHost.RegisterService<Journal.Entities.Item.Service>();
            appHost.RegisterService<PaymentOrder.Service>();
            appHost.RegisterService<Tax.Service>();

            //appHost.GetContainer().RegisterAutoWiredType(typeof(Users.Service));

            //var container = appHost.GetContainer().Resolve<SimpleInjector.Container>();
            //container.RegisterManyForOpenGeneric(typeof(IQueryHandler<,>), typeof(Plugin).Assembly);
            //container.RegisterManyForOpenGeneric(typeof(IPagingQueryHandler<,>), typeof(Plugin).Assembly);

            //appHost.GetContainer().Register<Users.Service>((c) => new Users.Service(c.Resolve<IBus>()));
            appHost.GetContainer().RegisterValidators(typeof(Plugin).Assembly);
        }
    }
}