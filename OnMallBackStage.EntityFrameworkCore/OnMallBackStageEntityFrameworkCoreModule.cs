using Microsoft.Extensions.DependencyInjection;
using System;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace OnMallBackStage.EntityFrameworkCore
{
    [DependsOn(typeof(AbpEntityFrameworkCoreModule))]
    public class OnMallBackStageEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<OnMallBackStageDbContext>(opt =>
            {
                opt.AddDefaultRepositories(true);//添加默认仓储
            });

            Configure<AbpDbContextOptions>(options =>
            {
                options.UseMySQL();
            });
            base.ConfigureServices(context);
        }
    }
}
