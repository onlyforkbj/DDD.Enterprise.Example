﻿using Demo.Library.Responses;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.ServiceStack.Configuration.Region.Entities.Match.Services
{
    [Api("Configuration")]
    [Route("/configuration/region/{RegionId}/match/{MatchId}/type", "PUT POST")]
    public class ChangeType : IReturn<Base<Command>>
    {
        public Guid RegionId { get; set; }

        public Guid MatchId { get; set; }

        public String Type { get; set; }
    }
}