﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YashodipPlyAndHardware.Models
{
    public class Subcategory
    {
        [Key]
        public int Id { get; set; }
        public string SubcategoryName { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; } 
 
      //  public string CategoryName { get; set; }
    }
}
