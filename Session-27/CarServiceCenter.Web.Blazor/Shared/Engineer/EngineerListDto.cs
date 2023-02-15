using CarServiceCenter.Model;
using CarServiceCenter.Web.Blazor.Shared.TransactionLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.Web.Blazor.Shared {
    public class EngineerListDto {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int SalaryPerMonth { get; set; }

        // Relations
        public int ManagerId { get; set; }

        public List<ManagerListDto> Managers { get; set; } = new();

        public List<TransactionLineListDto> TransactionLines { get; set; }= new List<TransactionLineListDto>();
    }
}
