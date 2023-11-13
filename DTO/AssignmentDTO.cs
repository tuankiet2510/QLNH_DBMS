using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AssignmentDTO
    {
        private string employeeId;
        private string shiftId;
        private DateTime workingDate;
        public AssignmentDTO(string employeeId, string shiftId, DateTime workingDate)
        {
            this.employeeId = employeeId;
            this.shiftId = shiftId;
            this.workingDate = workingDate;
        }

        public string EmployeeId { get { return employeeId; } set { employeeId = value; } }
        public string ShiftId { get { return shiftId; } set { shiftId = value; } }
        public DateTime WorkingDate { get { return workingDate; } set { workingDate = value; } }

    }
}
