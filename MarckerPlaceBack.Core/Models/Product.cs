using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarckerPlaceBack.Core.Models
{
    public class Product
    {
        [Key]
        public long ProductId { get; set; }
        public required string Name { get; set; }
        public int CategoryId { get; set; }
        public required string Articul { get; set; }

        [Precision(18, 2)]
        public decimal Price { get; set; }

        public virtual Category Category { get; set; }
    }
}
