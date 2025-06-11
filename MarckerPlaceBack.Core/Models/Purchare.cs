using Microsoft.EntityFrameworkCore;
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
        [Precision(18, 2)]
        public required decimal TotalPrice { get; set; }

        public required long CustomerId {  get; set; }

        public virtual Customer Customer { get; set; }
        public List<PurchareToProduct> PurchareToProducts { get; set; }
    }
}
