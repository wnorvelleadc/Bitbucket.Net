﻿using System.Collections.Generic;

namespace Bitbucket.Net.Core.Models.Admin
{
    public class MergeStrategies
    {
        public MergeStrategy DefaultStrategy { get; set; }

        public List<MergeStrategy> Strategies { get; set; }

        public string Type { get; set; }
    }
}
