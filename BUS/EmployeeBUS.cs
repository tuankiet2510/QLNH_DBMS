using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class EmployeeBUS
    {
        public string err;
        EmployeeDAO employeeDAO;

        public EmployeeBUS()
        {
            this.employeeDAO = new EmployeeDAO();
        }
        public DataTable getAllEmployee()
        {
            return employeeDAO.getAllEmployee();
        }

        public DataTable searchEmployee(EmployeeDTO employeeDTO, string type)
        {
            return employeeDAO.searchEmployee(employeeDTO, type);
        }

        public DataTable CalWageEmployee()
        {
            return employeeDAO.CalWageEmployee();
        }
        public bool addEmployee(EmployeeDTO employeeDTO)
        {
            return employeeDAO.Add_Employee(employeeDTO);
        }

        public bool editEmployee(EmployeeDTO employeeDTO)
        {
            return employeeDAO.Edit_Employee(employeeDTO);
        }

        public bool deleteEmployee(EmployeeDTO employeeDTO)
        {
            return employeeDAO.Delete_Employee(employeeDTO);
        }
    }
}
