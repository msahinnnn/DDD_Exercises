using Order.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.AggregateModels.OrderModels
{
    public class OrderItem: BaseEntity
    {

        public int Quantity  { get; private set; }
        public decimal Price { get; private set; }
        public int ProductId { get; private set; } 

        public OrderItem(int quantity, decimal price, int productId)
        {
            if (quantity < 0)
                throw new Exception("Quantity must be greater than zero.");

            if (price < 10)
                throw new Exception("Price must be at least 10$");

            Quantity = quantity;
            Price = price;
            ProductId = productId;
        }
    }
}
