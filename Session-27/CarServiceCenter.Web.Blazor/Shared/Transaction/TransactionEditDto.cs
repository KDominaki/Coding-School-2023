using CarServiceCenter.Model;
using CarServiceCenter.Web.Blazor.Shared.Car;
using CarServiceCenter.Web.Blazor.Shared.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.Web.Blazor.Shared.Transaction {
    public class TransactionEditDto {                        
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }

        // Relations
        public int CustomerId { get; set; }
        public CarServiceCenter.Model.Customer Customer { get; set; } = null!;

        public int ManagerId { get; set; }

        public CarServiceCenter.Model.Manager Manager { get; set; } = null!;


        public int CarId { get; set; }
        public CarServiceCenter.Model.Car Car { get; set; } = null!;

        public List<CarServiceCenter.Model.TransactionLine> TransactionLines { get; set; } = new();


    }
}
