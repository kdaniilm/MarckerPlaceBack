using MarckerPlaceBack.BLL.DTO;
using MarckerPlaceBack.BLL.Services.Interfaces;
using MarckerPlaceBack.Core.Context;
using MarckerPlaceBack.Core.Models;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<CustomerDTO>> GetBirthdayCustomerAsync(DateTime birthDay)
        {
            try
            {
                var customersWithBirthday = _dbContext.Customers.Where(c => c.BirthDay.Month == birthDay.Month && birthDay.Day == birthDay.Day);

                return customersWithBirthday.Any() ?
                    (await customersWithBirthday.Select(c => new CustomerDTO() { Id = c.CustomerId, FullName = ConfigureFullname(c) }).ToListAsync())
                    : new List<CustomerDTO>();
            }
            catch
            {
                throw;
            }
        }

        public async Task<IEnumerable<CustomerDTO>> GetLastCustomerAsync(int daysCount)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CategoriesDTO>> GetCustomerCategoriesAsync(long customerId)
        {
            throw new NotImplementedException();
        }

        private static string ConfigureFullname(Customer customer)
        {
            var fullname = $"{customer.Name}";

            fullname += !string.IsNullOrWhiteSpace(customer.MiddleName) ? $" {customer.MiddleName}" : "";

            fullname += $" {customer.LastName}";

            return fullname;
        }
    }
}
