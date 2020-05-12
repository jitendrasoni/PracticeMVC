using System.Collections.Generic;

namespace DIP.Cases.Case1.Wrong
{
    public class EmployeeManager
    {
        private readonly List<Employee> _employees;

        public EmployeeManager()
        {
            _employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }
    }

    public class EmployeeStatistics
    {
        private readonly EmployeeManager _empManager;

        public EmployeeStatistics(EmployeeManager empManager)
        {
            _empManager = empManager;
        }

        public int CountFemaleManagers()
        {
            return 0;
            //logic goes here
        }
    }

}