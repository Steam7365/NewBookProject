using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.EF
{
    public class BookTypeConfig : IEntityTypeConfiguration<BookType>
    {
        public void Configure(EntityTypeBuilder<BookType> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.TypeName).HasMaxLength(20);
            builder.Property(x => x.UpdateTime).HasColumnType("datetime");
            builder.Property(x => x.CreateTime).HasColumnType("datetime");
            builder.HasQueryFilter(x => x.IsDel == false);
        }
    }
}
