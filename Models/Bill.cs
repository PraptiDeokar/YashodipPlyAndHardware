using Microsoft.Data.SqlClient.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace YashodipPlyAndHardware.Models
{
    public class Bill
    {
        [Key]
        public int BillId { get; set; }

        [Required]
        public string CustomerName { get; set; }

       
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        [DataType(DataType.Date, ErrorMessage = "Invalid date format.")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Mobile number is required.")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Invalid mobile number.")]
        public string MobileNumber { get; set; }

        [Required]
        public string City { get; set; }

        public double? GstAmt { get; set; }
        public double? DisAmt { get; set; }
        public double? Tot { get; set; }

        public double? FinalTotal { get; set; }

        
    }
}
