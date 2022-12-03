using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Manufactures
{
    public class ManufactureConfiguration : IEntityTypeConfiguration<Manufacture>
    {
        public void Configure(EntityTypeBuilder<Manufacture> builder)
        {
            builder.ToTable(EcommerceConsts.DbTablePrefix + "Manufactures");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Code).HasMaxLength(50).IsUnicode(false).IsRequired();
            builder.Property(x => x.Slug).HasMaxLength(50).IsUnicode(false).IsRequired();
            builder.Property(x => x.CoverPicture).HasMaxLength(250);
        }
    }
}
