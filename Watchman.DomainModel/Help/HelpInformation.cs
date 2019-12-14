﻿using System;
using System.Collections.Generic;
using System.Text;
using Watchman.Integrations.MongoDB;

namespace Watchman.DomainModel.Help
{
    public class Description : Entity
    {
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public string Details { get; set; }
    }

    public class HelpInformation : Entity
    {
        public ulong ServerId { get; set; }
        public string MethodName { get; set; }
        public IEnumerable<Description> Descriptions { get; set; }
    }
}
