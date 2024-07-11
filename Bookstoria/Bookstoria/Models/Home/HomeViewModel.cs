using Bookworms.AplicationLogic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookworms.Models.Home
{
    public class HomeViewModel
    {
        public IEnumerable<Book> Books { get; set; }
    }
}
