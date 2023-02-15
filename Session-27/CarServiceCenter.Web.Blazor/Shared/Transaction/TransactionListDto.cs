using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.Web.Blazor.Shared.Transaction {
    public class TransactionListDto {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }

        // Properties below are from the relations, because maybe we want these to appear in the View as well   -- TODO: MAYBE NEEDS FIX 
        public string CustomerSurname { get; set; } = null!; 
        public string ManagerSurname { get; set; } = null!;
        public string CarRegistrationNumber { get; set; } = null!;  
        public decimal TransactionLinePrice { get; set; }   //maybe we need here multiple prices from multiple transaction lines
    }
}
