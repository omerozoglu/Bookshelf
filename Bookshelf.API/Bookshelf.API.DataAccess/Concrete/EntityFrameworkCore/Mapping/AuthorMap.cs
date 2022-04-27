using Bookshelf.API.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookshelf.API.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class AuthorMap : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();
            builder.HasMany(I=>I.Books).WithOne(I=>I.Author).HasForeignKey("BookID");
        }
    }
}
