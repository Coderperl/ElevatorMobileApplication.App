using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorMobileApplication.Models
{
    public class Case
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Elevator Elevator { get; set; }
        public Technician Technician { get; set; }
        public List<Comment> Comments { get; set; }
        public string Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CaseCreated { get; set; }
        public DateTime CaseEnded { get; set; }
    }
}
