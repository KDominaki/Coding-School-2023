﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class PetReport
    {
        public DateTime Year { get; set; }
        public DateTime Month { get; set; }
        public AnimalType Animal { get; set; }
        
        public decimal TotalSold { get; set; }


        public PetReport()
        {

        }
    }
}
