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
            //Kolon özellekilerini burada ayarlıyoruz.
             //builder.HasMany(I=>I.).WithOne(I=>I.)HasForeignKey
             //(I=>I.).OnDelete(DeleteBehavior.Casdae)
        }
    }
}
