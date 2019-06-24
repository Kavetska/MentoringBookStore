namespace AmazonCosplay.ModelConfiguration
{
    using Model;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    public class BookPlatformConfiguration : IEntityTypeConfiguration<BookPlatform>
    {
        public void Configure(EntityTypeBuilder<BookPlatform> builder)
        {
            builder.HasKey(t => new { t.BookId, t.PlatformId });

            builder.HasOne(bp => bp.Book)
                .WithMany(book => book.BookPlatforms)
                .HasForeignKey(bp => bp.BookId);

            builder.HasOne(bp => bp.Platform)
                .WithMany(platform => platform.BookPlatforms)
                .HasForeignKey(bp => bp.PlatformId);
        }
    }
}
