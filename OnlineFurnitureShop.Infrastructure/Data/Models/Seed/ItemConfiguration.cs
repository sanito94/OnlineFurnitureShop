using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFurnitureShop.Infrastructure.Data.Models.Seed
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            var data = new SeedData();

            builder.HasData(new Item[]
            {
                data.Chair, data.GaminChair, data.WoodChair
            });
        }
    }
}
