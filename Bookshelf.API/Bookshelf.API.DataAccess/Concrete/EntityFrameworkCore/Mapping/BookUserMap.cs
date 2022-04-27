using Bookshelf.API.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookshelf.API.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class BookUserMap : IEntityTypeConfiguration<BookUser>
    {
        public void Configure(EntityTypeBuilder<BookUser> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();
            builder.HasOne(I => I.Book).WithMany(I => I.BookUsers).HasForeignKey("BookUserID");
           // builder.HasOne(I => I.User).WithMany(I => I.BookUsers).HasForeignKey("UserBookID");
        }
    }
}
