using OnlineFurnitureShop.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OnlineFurnitureShop.Core.Extensions
{
    public static class ModelExtensions
    {
        public static string GetInformation(this IItemModel model)
        {
            string info = model.Name.Replace(" ", "-") + GetDescription(model.Description);

            info = Regex.Replace(info, @"[^a-zA-Z0-9\-]", string.Empty);
            return info;
        }

        private static string GetDescription(string position)
        {
            position = string.Join("-", position.Split(' ').Take(3));

            return position;
        }
    }
}
