﻿using Tests.Framework.Configuration;

namespace Profiling
{
    public class ProfilingTestConfiguration : YamlConfiguration
    {
        public override bool RunIntegrationTests => true;

        public override bool TestAgainstAlreadyRunningElasticsearch { get; protected set; } = true;

        public ProfilingTestConfiguration() 
            : base(@"..\..\..\..\Tests\tests.yaml")
        {
        }
    }
}