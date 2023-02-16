using CarServiceCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceCenter.EF;
using CarServiceCenter.Web.Blazor.Shared.TransactionLine;

namespace CarServiceCenter.Web.Blazor.Shared {
    public class EngineerEditDto {

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public int SalaryPerMonth { get; set; }

        // Relations
        public int ManagerId { get; set; }
        public List<ManagerListDto> Managers { get; set; } = new List<ManagerListDto>() ;

        public List<TransactionLineListDto> TransactionLines = new List<TransactionLineListDto>();
    }
}
