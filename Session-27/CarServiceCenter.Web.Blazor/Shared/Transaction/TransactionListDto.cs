using CarServiceCenter.Web.Blazor.Shared.Car;
using CarServiceCenter.Web.Blazor.Shared.Customer;
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


        public int CustomerId { get; set; }
        public List<CustomerListDto> Customer { get; set; } = new();

        public int ManagerId { get; set; }

        public List<ManagerListDto> Manager { get; set; } = new();

        public int CarId { get; set; }

        public List<CarListDto> Car { get; set; } = new();


        public List<CarServiceCenter.Model.TransactionLine> TransactionLines { get; set; } = new();

    }
}
