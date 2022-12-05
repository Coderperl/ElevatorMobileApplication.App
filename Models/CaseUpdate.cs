using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorMobileApplication.Models
{
    public class CaseUpdate
    {
        public int TechnicianId { get; set; }
        public string? Comment { get; set; }
        public string Status { get; set; }
        public DateTime CaseEnded { get; set; } = DateTime.Now;
    }
}
