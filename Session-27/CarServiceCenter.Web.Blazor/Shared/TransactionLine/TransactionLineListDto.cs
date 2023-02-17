using CarServiceCenter.Web.Blazor.Shared.ServiceTask;
using CarServiceCenter.Web.Blazor.Shared.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.Web.Blazor.Shared.TransactionLine {
    public class TransactionLineListDto {
        public int Id { get; set; }
        public decimal Hours { get; set; }
        public decimal PricePerHour { get; set; }
        public decimal Price { get; set; }

        // Relations
        public int TransactionId { get; set; }
        public List<TransactionListDto> Transactions { get; set; } = new();

        public int ServiceTaskId { get; set; }
        //public string ServiceTaskCode { get; set; } = null!;  //maybe we need this instead of just id
        public List<ServiceTaskListDto> ServiceTasks { get; set; } = new();

        public int EngineerId { get; set; }
        //public string EngineerSurname { get; set; } = null!; //maybe we need this instead of just id

        public List<EngineerListDto> Engineers { get; set; } = new();
    }
}

