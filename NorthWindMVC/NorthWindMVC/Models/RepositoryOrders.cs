namespace NorthWindMVC.Models
{
    public class RepositoryOrders
    {
        private NorthwindContext _context;//important if not given then you will get null pointer exception
        public RepositoryOrders(NorthwindContext context)
        {
            _context = context;
        }
        public List<int> GetAllOrderId()
        {
            List<int> allorderid = (from o in _context.Orders
                                    select o.OrderId).ToList();
            return allorderid;
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
        //LINQ - Language integrated query //query on collection
        public List<Order> FindOrderByCustomerId(string customerID)
        {
            /* Defenition for the lambda LINQ statement below
            List<Order> orderList = new List<Order>();
            foreach(var item in _context.Orders)
            {
                if(item.CustomerId == customerID)
                {
                    orderList.Add(item);
                }
            }
            */
            List<Order> customerOrders=(from o in _context.Orders
                                        where o.CustomerId == customerID
                                        select o).ToList();
            return customerOrders;
        }
        public List<OrderDetail> FindOrderDetailByOrderId(int orderid)
        {
            List<OrderDetail> orderDetails=(from od in _context.OrderDetails
                                            where od.OrderId == orderid
                                            select od).ToList();
            return orderDetails;
        }
        public Product FindProductById(int productid)
        {
            var productById = (Product)(from p in _context.Products
                               where p.ProductId == productid
                               select p);
            return productById;
        }
    }
}
