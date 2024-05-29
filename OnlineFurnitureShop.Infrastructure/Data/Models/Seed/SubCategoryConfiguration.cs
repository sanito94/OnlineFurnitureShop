using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFurnitureShop.Infrastructure.Data.Models.Seed
{
    public class SubCategoryConfiguration : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            var data = new SeedData();

            builder.HasData(new SubCategory[]
            {
                data.WoodChairSubCategory, data.LeatherChairSubCategory,
            });
        }
    }
}
