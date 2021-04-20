using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace OnMallBackStage.Domain.MerchandiseInfo
{
    public class Comment : Entity<int>
    {
        public string Level { get; set; }
        public int MerchandiseId { get; set; }
        public string CommentDetail { get; set; }
    }
}
