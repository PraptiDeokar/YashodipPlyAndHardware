using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YashodipPlyAndHardware.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public double Rate { get; set; }
        [Required]
        public double CustomerRate { get; set; }

        [Required]
        public double Quantity { get; set; }
        public string Description { get; set; }

        [Required]
        [ForeignKey("Subcategory")]
        public int SubcategoryId { get; set; }
        public Subcategory Subcategory { get; set; }

        public int CategoryId { get; set; }



    }
}
