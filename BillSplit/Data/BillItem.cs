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

        [Required(ErrorMessage = "Payers are Required")]
        [MinLength(1, ErrorMessage = "Must have at least 1 Payer")]
        public HashSet<string> Payers { get; set; }

        public BillItem()
        {

        }

        public BillItem(string name, double price, HashSet<string> payers)
        {
            Name = name;
            Price = price;
            Payers = payers;
        }
    }
}
