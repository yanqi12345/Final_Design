using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace OnMallBackStage.Domain.ManagerInfo
{
    public class Manager : Entity<int>
    {
        public string ManagerNo { get; set; }
        public string ManagerPassword { get; set; }
    }
}
