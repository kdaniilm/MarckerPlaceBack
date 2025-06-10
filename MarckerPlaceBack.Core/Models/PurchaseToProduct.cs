using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarckerPlaceBack.Core.Models
{
    public class PurchaseToProduct
    {
        public long PurchaseToProductId { get; set; }
        public long ProductId { get; set; }
        public long PurchaseId { get; set; }
        public int ProductsCount { get; set; }

        public virtual Product Product { get; set; }
        public virtual Purchare Purchare { get; set; }
    }
}
