using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.Web.Blazor.Shared.TransactionLine
{
    public class TransactionLineEditDto
    {
        public int Id { get; set; }
        public decimal Hours { get; set; }
        public decimal PricePerHour { get; set; }

        // These below are from the relations, maybe we need them to appear in the UI of TransactionLineList -- TODO: MAYBE NEEDS FIX
        public string ServiceTaskId { get; set; } = null!;
        public string EngineerSurname { get; set; } = null!;
    }
}

