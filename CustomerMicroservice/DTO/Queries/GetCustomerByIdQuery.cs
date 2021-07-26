using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CustomerMicroservice.DAL.Context;
using CustomerMicroservice.DAL.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CustomerMicroservice.DTO.Queries
{
    public class GetCustomerByIdQuery : IRequest<CustomerInfo>
    {
        private int Id { get; set; }
        public GetCustomerByIdQuery(int customerId)
        {
            if (customerId > 0)
                Id = customerId;
            else
                throw new Exception("Please provide valid customerid");
        }

        public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, CustomerInfo>
        {
            public GetCustomerByIdQueryHandler(IMyTestContext myTestContext)
            {
                _context = myTestContext;
            }

            private readonly IMyTestContext _context;
            public async Task<CustomerInfo> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
            {
                if (request.Id > 0)
                {
                    var customers = await _context.Customers.ToListAsync();
                    var customer = customers.Where(c => c.Id == request.Id).FirstOrDefault();

                    if (customer == null)
                        return null;
                    return customer;
                }
                return null;
            }
        }
    }
}
