using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entity
{
    public class Order_Details
    {
        //key
        public int Id { get; set; }
        //FK
        public int Order_Id { get; set; }
        public int Product_Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Product_Name { get; set; }
        public int Qty { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Discount { get; set; }


    }
}
