using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarckerPlaceBack.BLL.DTO
{
    public class CategoriesDTO
    {
        public required string CategoryName { get; set; }
        public required int PurcharedProductsCount { get; set; }
    }
}
