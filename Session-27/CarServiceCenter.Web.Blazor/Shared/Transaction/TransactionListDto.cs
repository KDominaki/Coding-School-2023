using CarServiceCenter.Web.Blazor.Shared.Car;
using CarServiceCenter.Web.Blazor.Shared.Customer;
using CarServiceCenter.Web.Blazor.Shared.TransactionLine;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
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
        public string CustomerSurname { get; set; } = null!;
        public List<CustomerListDto> Customers { get; set; } = new();

        public int ManagerId { get; set; }
        public string ManagerSurname { get; set; } = null!;

        public List<ManagerListDto> Managers { get; set; } = new();

        public int CarId { get; set; }
        public string CarRegistrationNumber { get; set; } = null!;

        public List<CarListDto> Cars { get; set; } = new();
        public List<TransactionListDto> TransactionLines { get; set; } = new();

    }
}
