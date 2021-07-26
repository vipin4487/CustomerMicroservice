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
using System.Threading.Tasks;

namespace CustomerMicroservice.DAL.Context
{
    public interface IMyTestContext
    {
        DbSet<CustomerInfo> Customers { get; set; }

        Task<int> SaveChanges();
    }
}