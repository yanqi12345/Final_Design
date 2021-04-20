using OnMallBackStage.EntityFrameworkCore;
using System;
using Volo.Abp.Application;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace OnMallBackStage.Application
{
    [DependsOn(
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule),
        typeof(OnMallBackStageEntityFrameworkCoreModule)
        )]
    public class OnMallBackStageApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);
            Configure<AbpAutoMapperOptions>(opt =>
            {
                opt.AddProfile<OnMallBackStageApplicationAutomapperProfile>();
            });
        }
    }
}
