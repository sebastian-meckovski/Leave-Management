using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Invalid name")]
        public string Name { get; set; }

        [Display(Name= "Default Number Of Days")]
        public int DefaultDays { get; set; }
    }
}
