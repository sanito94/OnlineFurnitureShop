using Microsoft.EntityFrameworkCore;
using OnlineFurnitureShop.Core.Contracts;
using OnlineFurnitureShop.Core.Models.Admin;
using OnlineFurnitureShop.Infrastructure.Data.Common;
using OnlineFurnitureShop.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFurnitureShop.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository repository;

        public UserService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<IEnumerable<UserServiceModel>> AllAsync()
        {
            return await repository.AllReadOnly<ApplicationUser>()
                .Select(u => new UserServiceModel()
                {
                    Email = u.Email,
                    FullName = $"{u.FirstName} {u.LastName}",
                    PhoneNumber = u.PhoneNumber,
                })
                .ToListAsync();
        }
    }
}
