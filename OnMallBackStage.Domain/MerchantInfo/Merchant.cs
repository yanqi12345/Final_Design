using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace OnMallBackStage.Domain.MerchantInfo
{
   public class Merchant:Entity<int>
    {
        public string MerchantNo { get; set; }
        public string MerchantName { get; set; }
        public string MerchantPassword { get; set; }
        public string MerchantTel { get; set; }

    }
}
