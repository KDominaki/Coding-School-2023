using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.Web.Blazor.Shared.ServiceTask
{
    public class ServiceTaskEditDto
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public decimal Hours { get; set; }
    }
}
