using CarServiceCenter.Model;
using CarServiceCenter.Web.Blazor.Shared;
using CarServiceCenter.Web.Blazor.Shared.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarServiceCenter.Web.Blazor.Shared {
    public class ManagerEditDto {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public int SalaryPerMonth { get; set; }


    
        public List<EngineerListDto> Engineers { get; set; } = new ();

        public List<TransactionEditDto> Transactions { get; set; } = new List<TransactionEditDto> ();


    }
}
