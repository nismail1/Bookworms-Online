using Bookworms.AplicationLogic.Abstractions;
using Bookworms.AplicationLogic.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Bookworms.EFDataAccess
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(BookwormsDbContext dbContext) : base(dbContext)
        {

        }

        public Order GetOrderByCustomer(Customer customer)
        {
            return dbContext.Orders
                            .Where(order => order.Customer == customer)
                            .SingleOrDefault();
        }

        public Order GetOrderByID(string orderID)
        {
            return dbContext.Orders
                            .Where(order => order.ID == Guid.Parse(orderID))
                            .SingleOrDefault();
        }

        public ICollection<Book> GetBooksFromOrder(string orderID)
        {
            return dbContext.Orders.Where(order => order.ID == Guid.Parse(orderID))
                            .SingleOrDefault().Books;
        }

        public double GetOrderPrice(string orderID)
        {
            return dbContext.Orders.Where(order => order.ID == Guid.Parse(orderID))
                            .SingleOrDefault().Price;
        }

        public double GetOrderQuantity(string orderID)
        {
            return dbContext.Orders.Where(order => order.ID == Guid.Parse(orderID))
                            .SingleOrDefault().Quantity;
        }
    }
}
