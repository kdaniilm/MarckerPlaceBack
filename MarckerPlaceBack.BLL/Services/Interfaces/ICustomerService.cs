using MarckerPlaceBack.BLL.DTO;

namespace MarckerPlaceBack.BLL.Services.Interfaces
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerDTO>> GetBirthdayCustomerAsync(DateTime birthDay);
        Task<IEnumerable<CurtomerLastBuyDTO>> GetLastCustomerBuyAsync(int daysCount);
    }
}
