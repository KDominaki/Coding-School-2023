using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.Web.Blazor.Shared.Customer {
    public class CustomerListDto {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Tin { get; set; } = null!;
    }
}
