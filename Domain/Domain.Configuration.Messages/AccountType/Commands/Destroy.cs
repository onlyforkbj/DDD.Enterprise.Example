﻿using Demo.Library.Command;
using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain.Configuration.AccountType.Commands
{
    public class Destroy : DemoCommand
    {
        public Guid AccountTypeId { get; set; }
    }
}