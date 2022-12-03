using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Ecommerce.Promotions
{
    public class Promotion : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string CouponCode { get; set; }
        public bool RequireUseCouponcode { get; set; }
        public DateTime ValidDate { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public double DiscountAmount { get; set; }
        public DiscountUnit DiscountUnit { get; set; }//enum DiscountUnit
        public bool LimittedUsageTime { get; set; }
        public uint MaximumDiscountAmount { get; set; }
        public bool IsActive { get; set; }



    }
}
