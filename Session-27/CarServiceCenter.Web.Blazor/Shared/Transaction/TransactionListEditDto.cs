using CarServiceCenter.Model;
using CarServiceCenter.Web.Blazor.Shared.Car;
using CarServiceCenter.Web.Blazor.Shared.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.Web.Blazor.Shared.Transaction {
    public class TransactionListEditDto {                               //TODO: MAYBE NEEDS FIXING
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }

        // Relations
        public int CustomerId { get; set; }
        public List<CustomerListDto> Customers { get; set; } = new();

        public int ManagerId { get; set; }
        //public List<ManagerListDto> Managers { get; set; } = new();   //TODO:  When ManagerListDto is ready, uncomment this line

        public int CarId { get; set; }
        public List<CarListDto> Car { get; set; } = new();


    }
}
