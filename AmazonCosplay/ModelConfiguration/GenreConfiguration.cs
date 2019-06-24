namespace AmazonCosplay.ModelConfiguration
{
    using Model;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasOne(genre => genre.ParentGenre)
                .WithMany()
                .HasForeignKey(genre => genre.ParentGenreId)
                .OnDelete(DeleteBehavior.ClientCascade);

            //TODO MANY BOOKS
        }
    }
}
