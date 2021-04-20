using System;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace OnMallBackStage.Domain
{
    [DependsOn(
       typeof(AbpDddDomainModule)
       )]
    public class OnMallBackStageDomainModule:AbpModule
    {
    }
}
