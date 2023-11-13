using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class ShiftBUS
    {
        ShiftDAO shiftDAO = new ShiftDAO();
        public DataTable GetAllShifts(string dateTime)
        {
            return shiftDAO.GetAllShifts(dateTime);
        }
        public bool createShift(ShiftDTO shiftDTO)
        {
            return shiftDAO.createShift(shiftDTO);
        }
        public bool createAssignment(AssignmentDTO assignmentDTO)
        {
            return shiftDAO.createAssigment(assignmentDTO);
        }
    }
}
