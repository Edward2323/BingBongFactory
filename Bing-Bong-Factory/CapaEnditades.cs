using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bing_Bong_Factory
{

    public class UserLogin
    {
        public int UserId { get; set; }
        public string UserRol { get; set; }
        public string UserFirstname { get; set; }
        public string UserLastname { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
    }

    public class Orders
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string EmployeeName { get; set; }
        public List<OrderDetails> OrderDetails { get; set; } = new List<OrderDetails>();
    }

    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitInStock { get; set; }
    }

    public class OrderDetails
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }

        // Relaciones
        public Orders Order { get; set; }
        public Products Product { get; set; }
    }

}
