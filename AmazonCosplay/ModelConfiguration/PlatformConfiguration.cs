namespace AmazonCosplay.ModelConfiguration
{
    using Model;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    public class PlatformConfiguration : IEntityTypeConfiguration<Platform>
    {
        //Mobile, browert
        public void Configure(EntityTypeBuilder<Platform> builder)
        {
            //TODO MANY BOOKS
            //TODO ENUMS
        }
    }
}