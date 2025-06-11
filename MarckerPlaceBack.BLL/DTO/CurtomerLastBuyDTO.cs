using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarckerPlaceBack.BLL.DTO
{
    public class CurtomerLastBuyDTO: CustomerDTO
    {
        public DateTime LastBuyDate { get; set; }
    }
}
