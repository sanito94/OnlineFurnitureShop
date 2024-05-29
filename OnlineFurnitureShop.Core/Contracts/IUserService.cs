using OnlineFurnitureShop.Core.Models.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFurnitureShop.Core.Contracts
{
    public interface IUserService
    {
        Task<IEnumerable<UserServiceModel>> AllAsync();
    }
}
