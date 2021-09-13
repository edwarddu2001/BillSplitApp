using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BillSplit.Data
{
    public class BillItem
    {
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Price is Required")]
        [Range(0, double.MaxValue, ErrorMessage = "Enter a Positive Number")]
        public double Price { get; set; }

        [Required(ErrorMessage = "People Paying are Required")]
        public List<string> Names { get; set; }
    }
}
