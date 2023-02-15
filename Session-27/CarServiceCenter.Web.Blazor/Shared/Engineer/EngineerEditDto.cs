using CarServiceCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.Web.Blazor.Shared.Engineer {
    public class EngineerEditDto {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int SalaryPerMonth { get; set; }

        // Relations
        public int ManagerId { get; set; }
        public CarServiceCenter.Model.Manager Manager { get; set; } = null!;
        public List<CarServiceCenter.Model.TransactionLine> TransactionLines { get; set; } = new List<Model.TransactionLine>();
    }
}
