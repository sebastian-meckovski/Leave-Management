using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Data
{
    public class LeaveType : BaseEntity
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        public string DefaultDays { get; set; }

    }
}

// This is basically a model. There are also viewmodels that Views can understand.
// Database can only understand models.