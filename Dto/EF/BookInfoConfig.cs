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
    public class BookInfoConfig : IEntityTypeConfiguration<BookInfo>
    {
        public void Configure(EntityTypeBuilder<BookInfo> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(100);
            builder.Property(x => x.Author).HasMaxLength(20);
            builder.Property(x => x.Description).HasMaxLength(500);
            builder.Property(x => x.UpdateTime).HasColumnType("datetime");
            builder.Property(x => x.CreateTime).HasColumnType("datetime");
            builder.HasQueryFilter(x => x.IsDel == false);
            builder.HasOne<BookType>(c => c.BookType).WithMany(a => a.BookInfos).IsRequired();
        }
    }
}
