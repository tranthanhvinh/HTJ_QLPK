using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer.DTO
{
    public class ProvisionalOrderDetailDTO
    {
        public System.Guid PODetailId { get; set; }
        public Nullable<System.Guid> ProvisionalOrderId { get; set; }
        public string GoldCode { get; set; }
        public string GoldName { get; set; }
        public Nullable<decimal> TotalGoldWeight { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> LineNumber { get; set; }
        public Nullable<decimal> Amount { get; set; }
    }
}
