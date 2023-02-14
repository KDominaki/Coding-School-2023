using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.Web.Blazor.Shared.Car
{
    public class CarEditDto
    {
        public int Id { get; set; }
        public string Bramd { get; set; } = string.Empty;
        public string Model { get; set; }
        public string CarRegistrationNumber { get; set; }
    }
}
