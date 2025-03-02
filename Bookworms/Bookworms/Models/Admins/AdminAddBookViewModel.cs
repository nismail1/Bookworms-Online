﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Bookworms.Models.Admins
{
    public class AdminAddBookViewModel
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public string ISBN { get; set; }
        public IFormFile Image { get; set; }
        public string CategoryType { get; set; }
        public double DiscountValue { get; set; }
    }
}
