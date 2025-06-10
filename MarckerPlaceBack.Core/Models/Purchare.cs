using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarckerPlaceBack.Core.Models
{
    public class Purchare
    {
        [Key]
        public long PurchareId { get; set; }
        public DateTime PurchareDate { get; set; }
        public string TotalPrice { get; set; }

        public List<Product> Products { get; set; }
    }
}
