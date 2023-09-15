using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class OrderDetailsRepository : GenericRepository<OrderDetail>, IOrderDetailsRepository
    {
        public OrderDetailsRepository(SuperStoreContext context) : base(context)
        {

        }
        public OrderDetail GetMostRecentOrderDetail()
        {
            return _context.OrderDetails.OrderByDescending(orderDetails => orderDetails.OrderDetailsId).FirstOrDefault();
        }
    }
}
