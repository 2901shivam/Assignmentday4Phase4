using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDayFour
{
    public class Product
    {
        public int Id { get; set; }

        public string? PName { get; set; }

        public int Price { get; set; }

        public string? PBrand { get; set; }

        public DateTime? ManufactureDate { get; set; }

        public DateTime? ExpDate { get; set; }
    }
}
