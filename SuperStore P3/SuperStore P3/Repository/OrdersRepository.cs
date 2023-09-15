using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class OrdersRepository : GenericRepository<Order>, IOrderRepository
    { 
        public OrdersRepository(SuperStoreContext context) : base(context)
        {

        }
        public Order GetMostRecentOrder()
        {
            return _context.Orders.OrderByDescending(order => order.OrderId).FirstOrDefault();
        }
        
    }
}
