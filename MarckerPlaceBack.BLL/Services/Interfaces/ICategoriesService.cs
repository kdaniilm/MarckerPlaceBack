using MarckerPlaceBack.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarckerPlaceBack.BLL.Services.Interfaces
{
    public interface ICategoriesService
    {
        Task<IEnumerable<PopularCategoriesDTO>> GetCustomerCategoriesAsync(long customerId);
    }
}
