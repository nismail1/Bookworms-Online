using Bookworms.AplicationLogic.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookworms.AplicationLogic.Abstractions
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Customer GetCustomerByUserID(Guid userID);
    }
}
