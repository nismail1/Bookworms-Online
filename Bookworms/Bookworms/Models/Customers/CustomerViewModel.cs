using System;
using Bookworms.AplicationLogic.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookworms.Models.Customers
{
    public class CustomerViewModel
    {
        public IEnumerable<Book> Books { get; set; }
    }
}
