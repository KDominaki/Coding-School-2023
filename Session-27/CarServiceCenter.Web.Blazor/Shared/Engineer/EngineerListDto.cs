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
        public string Name { get; set; } = null!;   
        public string Surname { get; set; } = null!;    
        public int SalaryPerMonth { get; set; }

        // Relations
        public int ManagerId { get; set; }

        public string ManagerSurname { get; set; } = null!;

        public List<ManagerListDto> Managers { get; set; } = new List<ManagerListDto>();

        public List<TransactionLineListDto> TransactionLines { get; set; }= new ();
    }
}
