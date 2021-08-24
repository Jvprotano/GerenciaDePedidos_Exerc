using Exe_SeçãoNove.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exe_SeçãoNove.Entities
{
    class Order
    {
        public DateTime moment { get; set; }
        public OrderStatus status{ get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client client { get; set; }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            this.moment = moment;
            this.status = status;
            this.client = client;
        }

        public void addItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void removeItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double total()
        {
            double total = 0;
            foreach (OrderItem item in Items)
            {
                total += item.price * item.quantity;
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); // Construindo um StringBuilder
            foreach (OrderItem item in Items)
            {
               
                sb.Append(item.product.name);
                sb.Append(", ");
                sb.Append(item.price);
                sb.Append(", Quantidade: ");
                sb.Append(item.quantity);
                sb.Append(", Subtotal: ");
                sb.Append(item.subTotal());
                sb.AppendLine();
            }
            return sb.ToString();
        }



    }   
}
