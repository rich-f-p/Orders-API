using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entity
{
    public class Order
    {
        //key
        public int Id { get; set; }
        public DateTime Order_Date { get; set; }
        public int CustomerId { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string CustomerName { get; set; }
        public int PaymentMethodId { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string PaymentName { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string ShippingAddress { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string ShippingMethod { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal BillAmount { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Order_Status { get; set; }

        public List<Order_Details>? Details { get; set; }
    }
}
