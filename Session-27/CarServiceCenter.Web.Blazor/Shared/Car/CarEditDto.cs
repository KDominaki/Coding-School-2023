using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.Web.Blazor.Shared.Car
{
    public class CarEditDto
    {
        public int Id { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        [MaxLength(10, ErrorMessage = "You have exceeded the limit of 10 characters")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Registration Number is required")]
        public string? CarRegistrationNumber { get; set; }
    }
}
