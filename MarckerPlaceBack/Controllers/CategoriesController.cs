using MarckerPlaceBack.BLL.DTO;
using MarckerPlaceBack.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MarckerPlaceBack.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesService _categoriesService;

        public CategoriesController(ICategoriesService customerService)
        {
            _categoriesService = customerService;
        }

        [HttpGet]
        [Route("popular")]
        public async Task<IEnumerable<PopularCategoriesDTO>> GetPopularCategoriesForCustomerAsync(long customerId)
        {
            return await _categoriesService.GetCustomerCategoriesAsync(customerId);
        }
    }
}
