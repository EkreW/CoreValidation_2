using CoreValidation_2.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreValidation_2.Models.Configuration
{
    public class CategoryConfiguration : BaseConfiguration<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.CategoryName).HasMaxLength(20);
        }
    }
}
