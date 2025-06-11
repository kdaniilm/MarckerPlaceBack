using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarckerPlaceBack.BLL.DTO
{
    public class CustomerDTO
    {
        public required long Id { get; set; }
        public required string FullName { get; set; }
    }
}
