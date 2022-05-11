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

            builder.Property(I => I.IsFav).HasDefaultValue(false);
            builder.Property(I => I.CreationDate).HasDefaultValue(DateTime.UtcNow);
            builder.Property(I => I.UpdateDate).HasDefaultValue(DateTime.UtcNow);
            builder.Property(I => I.IsDeleted).HasDefaultValue(false);
        }
    }
}
