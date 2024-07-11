using System;
using Bookworms.AplicationLogic.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookworms.Models.Admins
{
    public class AdminBooksViewModel
    {
        public Admin Admin { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
