using Bookworms.AplicationLogic.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookworms.AplicationLogic.Abstractions
{
    public interface IBookRepository : IRepository<Book>
    {
        Book GetBookByID(Guid bookID);
        Book GetBookByTitle(string title);
        string GetAuthorByBookID(Guid bookID);
        string GetTitle(string bookID);
        double GetPrice(string bookID);
        Category GetCategory(string bookID);
        Discount GetDiscount(string bookID);
    }
}
