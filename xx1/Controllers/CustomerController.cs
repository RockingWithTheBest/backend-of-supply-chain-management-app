﻿using Back_End.Models;
using Microsoft.AspNetCore.Mvc;
using xx1.Repository.Interface;

namespace xx1.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class CustomerController:ControllerBase
    {
        private readonly ICustomer icust;
        public CustomerController(ICustomer icust)
        {
            this.icust = icust;
        }

        [HttpGet]
        [Route("GetAllCustomers")]
        public IActionResult GetAll()
        {
            var customers = icust.GetAllCustomers();
            if(customers == null)
            {
                return NotFound("Not Customers exist");
            }
            else
            {
                return Ok(customers);
            }
        }

        [HttpGet]
        [Route("GetCustomerById")]
        public IActionResult GetById(int id)
        {
            var customer = icust.GetCustomerById(id);
            if(customer == null)
            {
                return NotFound("That Customer Id doesnt exist");
            }
            else
            {
                return Ok(customer);
            }
        }

        [HttpPost]
        [Route("AddCustomer-With-RoleId")]
        public IActionResult AddSingleCustomer(int RoleId, CustomerEntity customer)
        {            
            if (customer == null)
            {
                return BadRequest("Customer data is required.");
            }
            var customerInstance = icust.AddCustomer(customer, RoleId);

            if (customerInstance == -1)
            {
                return BadRequest("Not Successfully Added");
            }
            return Ok("Added :" + customerInstance);
        }
    }
}
