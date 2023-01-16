using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Volintiru.Models

{
    public class Food
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }


        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<DeliveryFood> DeliveryFoods { get; set; }
    }
}
