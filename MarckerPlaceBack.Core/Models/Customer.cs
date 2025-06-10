using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarckerPlaceBack.Core.Models
{
    public class Customer
    {
        [Key]
        public long CustomerId {  get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string LastName {  get; set; }
        public DateTime RegistationDate { get; set; }
    }
}
