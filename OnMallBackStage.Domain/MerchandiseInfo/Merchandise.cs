using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace OnMallBackStage.Domain.MerchandiseInfo
{
    public class Merchandise:Entity<int>
    {
        public string MerchandiseNo { get; set; }
        public string MerchandiseName { get; set; }
        public int Price { get; set; }
        public int Sum { get; set; }
        public string Picture { get; set; }
        public string Introduction { get; set; }
        public int ClassifyId { get; set; }
        public int MerchantId { get; set; }





    }
}
