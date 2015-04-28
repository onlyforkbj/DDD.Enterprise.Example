﻿using Demo.Library.Responses;
using ServiceStack.Model;
using System;

namespace Demo.Application.ServiceStack.Accounting.FiscalYear.Responses
{
    public class Get : IResponse, IHasGuidId
    {
        public Guid Id { get; set; }

        public String Code { get; set; }

        public String Name { get; set; }

        public Boolean Open { get; set; }

        public DateTime? Start { get; set; }

        public DateTime? End { get; set; }
    }
}