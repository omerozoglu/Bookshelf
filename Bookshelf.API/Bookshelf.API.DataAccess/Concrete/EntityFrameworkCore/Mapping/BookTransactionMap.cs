using Bookshelf.API.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookshelf.API.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class BookTransactionMap : IEntityTypeConfiguration<BookTransaction>
    {
        public void Configure(EntityTypeBuilder<BookTransaction> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.Property(I => I.LendDate).HasDefaultValue(DateTime.UtcNow);

            builder.HasOne(I => I.Book).WithMany(I => I.BookTransactions).HasForeignKey(I => I.BookId).OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
