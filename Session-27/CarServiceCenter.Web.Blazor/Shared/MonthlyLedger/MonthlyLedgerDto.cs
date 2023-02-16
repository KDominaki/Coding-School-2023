using CarServiceCenter.Model;
using CarServiceCenter.Web.Blazor.Shared.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.Web.Blazor.Shared.MonthlyLedger
{
    public class MonthlyLedgerDto {
        public decimal Expenses { get; set; }
        public decimal Income { get; set; }
        public decimal Total { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }

        //// The below maybe not needed
        //public List<TransactionListDto> Transactions { get; set; } = new();
        //public List<EngineerListDto> Engineers { get; set; } = new();
        //public List<ManagerListDto> Managers { get; set; } = new();    
    }
}
