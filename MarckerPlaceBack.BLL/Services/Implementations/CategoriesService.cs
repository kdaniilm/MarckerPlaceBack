using MarckerPlaceBack.BLL.DTO;
using MarckerPlaceBack.BLL.Services.Interfaces;
using MarckerPlaceBack.Core.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarckerPlaceBack.BLL.Services.Implementations
{
    public class CategoriesService: ICategoriesService
    {
        private readonly ApplicationDbContext _dbContext;

        public CategoriesService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<PopularCategoriesDTO>> GetCustomerCategoriesAsync(long customerId)
        {
            var userPurchareToProductsGroupByCategoryId = _dbContext.PurcharesToProducts.Include(ptp => ptp.Purchare).Where(ptp => ptp.Purchare.CustomerId == customerId)
                .GroupBy(ptp => ptp.Product.Category.CategoryName);


            var result = userPurchareToProductsGroupByCategoryId.Any() ?
                (await userPurchareToProductsGroupByCategoryId.Select(g => new PopularCategoriesDTO() { CategoryName = g.Key, PurcharedProductsCount = g.Sum(ptp => ptp.ProductsCount)}).ToListAsync())
                : new List<PopularCategoriesDTO>();

            return result;
        }
    }
}
