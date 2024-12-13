using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YashodipPlyAndHardware.Models
{
    public class BillViewModel
    {
        public int BillId { get; set; }
        public DateTime Date { get; set; }
       
        public string ProductName { get; set; }
        public double Quantity { get; set; }
    }

}
