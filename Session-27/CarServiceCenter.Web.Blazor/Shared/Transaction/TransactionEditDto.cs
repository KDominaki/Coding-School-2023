using CarServiceCenter.Model;
using CarServiceCenter.Web.Blazor.Shared.Car;
using CarServiceCenter.Web.Blazor.Shared.Customer;
using CarServiceCenter.Web.Blazor.Shared.TransactionLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.Web.Blazor.Shared {
    public class TransactionEditDto {                        
        public int Id { get; set; }

        public DateTime Date = DateTime.Now;
        public decimal TotalPrice { get; set; }

        // Relations
        public int CustomerId { get; set; }

        public List<CustomerListDto> Customers { get; set; } = new();


        public int ManagerId { get; set; }

        public List<ManagerListDto> Managers { get; set; } = new List<ManagerListDto>();
        public int CarId { get; set; }

        public List<CarListDto> Cars { get; set; } = new List<CarListDto>();

        public List<TransactionLineListDto> TransactionLines { get; set; } = new();


    }
}
