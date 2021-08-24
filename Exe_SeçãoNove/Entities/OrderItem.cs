using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_SeçãoNove.Entities
{
    class OrderItem
    {
        public int quantity { get; set; }
        public double price { get; set; }
        public Product product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, Product product)
        {
            this.quantity = quantity;
            this.price = product.price;
            this.product = product;
        }

        public double subTotal()
        {
            return quantity * price;
        }

       
    }
    
    





}
