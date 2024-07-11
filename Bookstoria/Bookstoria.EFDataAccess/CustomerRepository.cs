using Bookworms.AplicationLogic.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Bookworms.AplicationLogic.Abstractions;

namespace Bookworms.EFDataAccess
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(BookwormsDbContext dbContext) : base(dbContext)
        {

        }

        public Customer GetCustomerByUserID(Guid id)
        {
            return dbContext.Customers
                            .Where(customer => customer.ID == id)
                            .SingleOrDefault();
        }

    }
}
