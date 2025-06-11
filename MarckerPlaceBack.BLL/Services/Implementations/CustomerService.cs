using MarckerPlaceBack.BLL.DTO;
using MarckerPlaceBack.BLL.Services.Interfaces;
using MarckerPlaceBack.Core.Context;
using MarckerPlaceBack.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarckerPlaceBack.BLL.Services.Implementations
{
    public class CustomerService : ICustomerService
    {
        private readonly ApplicationDbContext _dbContext;

        public CustomerService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<ClientsDTO>> GetBirthdayCustomerAsync(DateTime birthDay)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ClientsDTO>> GetLastCustomerAsync(int daysCount)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CategoriesDTO>> GetCustomerCategoriesAsync(long customerId)
        {
            throw new NotImplementedException();
        }
    }
}
