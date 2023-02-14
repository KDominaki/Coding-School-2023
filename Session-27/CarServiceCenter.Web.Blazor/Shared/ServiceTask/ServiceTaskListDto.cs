using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.Web.Blazor.Shared.ServiceTask
{
    public class ServiceTaskListDto
    {
        public int Id { get; set; }
        public string? Code { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public decimal Hours { get; set; }
    }
}
