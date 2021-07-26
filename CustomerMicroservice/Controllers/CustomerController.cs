using CustomerMicroservice.DAL.Entities;
using CustomerMicroservice.DTO;
using CustomerMicroservice.DTO.Commands;
using CustomerMicroservice.DTO.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerMicroservice
{
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetCustomers")]
        public async Task<IEnumerable<CustomerInfo>> GetCustomers()
        {
            return await _mediator.Send(new GetAllCustomersQuery());
        }

        [HttpGet("{GetCustomerById}")]
        public async Task<CustomerInfo> GetCustomerById(int id)
        {
            return await _mediator.Send(new GetCustomerByIdQuery(id));
        }

        [HttpPost("CreateCustomer")]
        public async Task<int> CreateCustomer([FromBody] CreateCustomerCommand command)
        {
            return await _mediator.Send(new CreateCustomerCommand());
        }
    }
}
