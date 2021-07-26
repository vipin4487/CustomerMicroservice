using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CustomerMicroservice.DAL.Context;
using CustomerMicroservice.DAL.Entities;
using MediatR;
namespace CustomerMicroservice.DTO.Commands
{
    public class CreateCustomerCommand : IRequest<int>
    {
        public string CustomerName { get; set; }
        public string Phone { get; set; }

        //public CreateCustomerCommand(string customerName, string phone)
        //{
        //    CustomerName = customerName;
        //    Phone = phone;
        //}

        public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, int>
        {
            private readonly IMyTestContext _context;
            public CreateCustomerCommandHandler(IMyTestContext myTestContext)
            {
                _context = myTestContext;
            }
            public async Task<int> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
            {
                var customer = new CustomerInfo(request.CustomerName, request.Phone);
                _context.Customers.Add(customer);
                int result = await _context.SaveChanges();
                return customer.Id;
            }
        }
    }
}
