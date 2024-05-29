using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFurnitureShop.Infrastructure.Data.Models.Seed
{
    public class SeedData
    {
        public ApplicationUser AdminUser { get; set; }

        public Category ChairCategory { get; set; }

        public SubCategory WoodChairSubCategory { get; set; }
        public SubCategory LeatherChairSubCategory { get; set; }

        public Item Chair { get; set; }
        public Item WoodChair { get; set; }
        public Item GaminChair { get; set; }


        public SeedData()
        {
            SeedUsers();
            SeedCategory();
            SeedSubCategory();
            SeedItem();
        }

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();

            AdminUser = new ApplicationUser()
            {
                Id = "5321f824-d6f9-4a58-beef-03b7bc3d6fa4",
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@MAIL.COM",
                FirstName = "Great",
                LastName = "Admin",
                Address = "ul. Pliska 4, bl. Preslav, grad Ruse",
                PostalCode = "7000",
                PhoneNumber = "+491787181664"
            };

            AdminUser.PasswordHash =
            hasher.HashPassword(AdminUser, "admin");
        }

        private void SeedCategory()
        {
            ChairCategory = new Category()
            {
                Id = 1,
                Name = "Chair",
            };
        }

        private void SeedSubCategory()
        {
            WoodChairSubCategory = new SubCategory()
            {
                Id = 1,
                CategoryId = 1,
                Name = "Wood"
            };

            LeatherChairSubCategory = new SubCategory()
            {
                Id = 2,
                CategoryId = 1,
                Name = "Leather"
            };
        }

        private void SeedItem() 
        {
            Chair = new Item()
            {
                Id = 1,
                CategoryId = 1,
                SubCategoryId = 2,
                Price = 30,
                Name = "Leather Gaming Chair PK2000",
                Description = "Super cool gaming chair and very comfy",
                ImageUrl = "https://png.pngtree.com/png-clipart/20230213/ourmid/pngtree-black-gaming-chair-png-image_6596551.png"
            };

            GaminChair = new Item()
            {
                Id = 2,
                CategoryId = 1,
                SubCategoryId = 2,
                Price = 20,
                Name = "Gaming Chair PK1200",
                Description = "Gaming Chair from the best leather",
                ImageUrl = "https://png.pngtree.com/png-clipart/20230316/ourmid/pngtree-realistic-3d-gaming-chair-yellow-and-black-color-png-image_6652203.png"
            };

            WoodChair = new Item()
            {
                Id = 3,
                CategoryId = 1,
                SubCategoryId = 1,
                Price = 5,
                Name = "Wood Chair",
                Description = "Wood chair but very comfy",
                ImageUrl = "https://png.pngtree.com/png-vector/20230912/ourmid/pngtree-home-and-office-wooden-chair-isolated-png-image_10025185.png"
            };
        }
    }

}
