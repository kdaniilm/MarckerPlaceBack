using MarckerPlaceBack.BLL.DTO;

namespace MarckerPlaceBack.BLL.Services.Interfaces
{
    public interface ICustomerService
    {
        Task<IEnumerable<ClientsDTO>> GetBirthdayCustomerAsync(DateTime birthDay);
        Task<IEnumerable<ClientsDTO>> GetLastCustomerAsync(int daysCount);
        Task<IEnumerable<CategoriesDTO>> GetCustomerCategoriesAsync(long customerId);
    }
}
