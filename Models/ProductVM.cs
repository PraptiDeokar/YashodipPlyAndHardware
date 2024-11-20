using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YashodipPlyAndHardware.Models
{
    public class ProductVM
    {
        [ForeignKey("Product")]
        public string ProductName { get; set; }
        public Product Product { get; set; }

        [ForeignKey("Subcategory")]
        public string PSubcategory { get; set; }
        public Subcategory Subcategory  { get; set; }

        [ForeignKey("Category")]
        public string PCategory { get; set; }
        public Category Category { get; set; }

    }
}
