using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilApp.Entities
{
    public class Brands
    {
        [Key]
        public int BrandId { get; set; }
        public string Brand {  get; set; }
    }
}
