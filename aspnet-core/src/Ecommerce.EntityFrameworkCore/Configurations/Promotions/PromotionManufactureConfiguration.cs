using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Promotions
{
    public class PromotionManufactureConfiguration : IEntityTypeConfiguration<PromotionManufacture>
    {
        public void Configure(EntityTypeBuilder<PromotionManufacture> builder)
        {
            builder.ToTable(EcommerceConsts.DbTablePrefix + "PromotionManufactures");
            builder.HasKey(x => x.Id);
        }
    }
}
