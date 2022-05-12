﻿using Bookshelf.API.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookshelf.API.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.Property(I => I.ISBN).HasMaxLength(13);

            builder.HasMany(I => I.BookUsers).WithOne(I=>I.Book).HasForeignKey(I => I.BookId);
        }
    }
}
