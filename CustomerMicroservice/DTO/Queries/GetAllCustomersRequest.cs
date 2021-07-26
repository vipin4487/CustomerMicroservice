using CustomerMicroservice.DAL.Context;
using CustomerMicroservice.DAL.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CustomerMicroservice.DTO.Queries
{
    public class GetAllCustomersQuery : IRequest<IEnumerable<CustomerInfo>>
    {
        public class GetAllCustomersQueryHandler : IRequestHandler<GetAllCustomersQuery, IEnumerable<CustomerInfo>>
        {
            private readonly IMyTestContext _context;
            public GetAllCustomersQueryHandler(IMyTestContext myTestContext)
            {
                _context = myTestContext;
            }
            public async Task<IEnumerable<CustomerInfo>> Handle(GetAllCustomersQuery request, CancellationToken cancellationToken)
            {
                var result = await _context.Customers.ToListAsync();
                if (result == null)
                    return null;

                return result.AsReadOnly();
            }
        }
    }
}
