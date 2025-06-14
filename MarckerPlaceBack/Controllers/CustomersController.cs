﻿using MarckerPlaceBack.BLL.DTO;
using MarckerPlaceBack.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarckerPlaceBack.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        [Route("birthday")]
        public async Task<IEnumerable<CustomerDTO>> GetBirthdayCustomersAsync(DateTime birthDate)
        {
            return await _customerService.GetBirthdayCustomerAsync(birthDate);
        }

        [HttpGet]
        [Route("last")]
        public async Task<IEnumerable<CurtomerLastBuyDTO>> GetLastCustomerBuyAsync(int daysCount)
        {
            return await _customerService.GetLastCustomerBuyAsync(daysCount);
        }
    }
}
