using Microsoft.EntityFrameworkCore;
using OnMallBackStage.Domain.ManagerInfo;
using OnMallBackStage.Domain.MerchandiseInfo;
using OnMallBackStage.Domain.MerchantInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace OnMallBackStage.EntityFrameworkCore
{
    [ConnectionStringName("Default")]
    public class OnMallBackStageDbContext:AbpDbContext<OnMallBackStageDbContext>
    {
        public DbSet<Manager> Managers{ get; set; }
        public DbSet<Classify> Classifies { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Merchandise> Merchandises { get; set; }
        public DbSet<Merchant> Merchants { get; set; }


        public OnMallBackStageDbContext(DbContextOptions<OnMallBackStageDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
