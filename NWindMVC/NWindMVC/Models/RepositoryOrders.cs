namespace NWindMVC.Models
{
    public class RepositoryOrders
    {
        private NorthwindContext _context;
        public RepositoryOrders(NorthwindContext context)
        {
            _context = context;
        }
        public List<int> GetAllOrderId()
        {
            List<int> allOrderid = (from o in _context.Orders select o.OrderId).ToList();
            return allOrderid;
        }
        public List<Order> AllOrders()
        {
            return _context.Orders.ToList();
        }

        public Order FindOrderById(int id)
        {
            Order orderById = _context.Orders.Find(id);
            return orderById;
        }
        public List<OrderDetail> FindOrderDetailByOrderId(int id)
        {
            Order order = _context.Orders.Find(id);
            return order.OrderDetails.ToList();
        }
    }
}
