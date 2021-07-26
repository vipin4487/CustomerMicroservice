/* This code contains copyright information which is the proprietary property
* of SITA Information Networking Computing USA. No part of this code may be reproduced,
* stored or transmitted in any form without the prior written permission of
* SITA Information Networking Computing USA.
*
* Copyright SITA Information Networking Computing USA Inc  .
* Confidential. All rights reserved.
*/
using CustomerMicroservice.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerMicroservice.DAL.Context
{
    public class MyTestContext : DbContext, IMyTestContext
    {
        public DbSet<CustomerInfo> Customers { get; set; }
        public MyTestContext(DbContextOptions<MyTestContext> options) : base(options)
        {

        }

        public async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }
    }
}