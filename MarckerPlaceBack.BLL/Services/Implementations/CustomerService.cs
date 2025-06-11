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

        public async Task<IEnumerable<CurtomerLastBuyDTO>> GetLastCustomerBuyAsync(int daysCount)
        {
            var fromDate = DateTime.Now.AddDays(-daysCount);
            var purcharesFromDate = _dbContext.Purchares.Include(p => p.Customer).Where(p => p.PurchareDate >= fromDate);

            var result = purcharesFromDate.Any() ?
                (await purcharesFromDate.Select(p => new CurtomerLastBuyDTO() { Id = p.Customer.CustomerId, FullName = ConfigureFullname(p.Customer), LastBuyDate = p.PurchareDate })
                    .OrderByDescending(clb => clb.LastBuyDate).ToListAsync())
                : new List<CurtomerLastBuyDTO>();

            result = result.DistinctBy(r => r.Id).ToList();

            return result;
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
