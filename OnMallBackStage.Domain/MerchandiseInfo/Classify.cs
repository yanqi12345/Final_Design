using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace OnMallBackStage.Domain.MerchandiseInfo
{
    public class Classify : Entity<int>
    {
        public string ClassDetail { get; set; }
    }
}
