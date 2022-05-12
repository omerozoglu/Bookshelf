using Bookshelf.API.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Bookshelf.API.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.Property(I => I.IsActive).HasDefaultValue(true);
            builder.Property(I => I.CreationDate).HasDefaultValue(DateTime.UtcNow);
            builder.Property(I => I.UpdateDate).HasDefaultValue(DateTime.UtcNow);
            builder.Property(I => I.IsDeleted).HasDefaultValue(false);

            builder.HasMany(I => I.BookUsers).WithOne(I => I.User).HasForeignKey(I => I.UserId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
