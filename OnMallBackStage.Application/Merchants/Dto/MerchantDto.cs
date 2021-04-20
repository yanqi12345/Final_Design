using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace OnMallBackStage.Application.Merchants.Dto
{
    public class MerchantDto:EntityDto<int>
    {
        public string MerchantNo { get; set; }
        public string MerchantName { get; set; }
        public string MerchantPassword { get; set; }
        public string MerchantTel { get; set; }
    }
}
