using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.Web.Blazor.Shared.TransactionLine {
    public class TransactionLineListDto {
        public decimal Hours { get; set; }
        public decimal PricePerHour { get; set; }

        // These below are from the relations, maybe we need them to appear in the UI of TransactionLineList -- TODO: MAYBE NEEDS FIX
        public string ServiceTaskCode { get; set; } = null!;
        public string EngineerSurname { get; set; } = null!;
    }
}
