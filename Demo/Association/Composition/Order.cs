using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Association.Composition
{
     class Order
    {
        //Assosition Relationship [composition]: Has A
        //Order Has A Items
        public int Id { get; set; }
        public string BuyerEmail { get; set;}
        public decimal SubTotal { get; set; }
        public OrderItem[] Items { get; set; }

        public Order(string BuyerEmail, OrderItem[] Items)
        {
            this.BuyerEmail = BuyerEmail;
            this.Items = Items;
        }
    }
}
