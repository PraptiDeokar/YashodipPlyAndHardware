using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using YashodipPlyAndHardware.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YashodipPlyAndHardware.Models
{
    public class BillChild
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Bill")]
        public int BillId { get; set; }
        public Bill Bill {  get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public double Price { get; set; }
        public double Quantity {  get; set; }
        public double Tot { get; set; }
        public int SubcategoryId { get; set; }
        public int CategoryId { get; set; }
     

    }
}
