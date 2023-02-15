﻿using CarServiceCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarServiceCenter.Web.Blazor.Shared {
    public class ManagerEditDto {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int SalaryPerMonth { get; set; }

        public List<CarServiceCenter.Model.Engineer> Engineers { get; set; }

        public List<Transaction> Transactions { get; set; }
    }
}
