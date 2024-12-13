using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YashodipPlyAndHardware.Models
{
    [Keyless]
    public class SalesSummaryClass
    {
      //  public int Id { get; set; }
        public string CategoryName { get; set; }
        public string SubcategoryName { get; set; }
        public string ProductName { get; set; }
        public double Quantity { get; set; }
    }

}
