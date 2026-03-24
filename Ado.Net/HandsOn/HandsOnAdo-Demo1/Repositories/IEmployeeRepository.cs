using HandsOnAdo_Demo1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnAdo_Demo1.Repositories
{
    internal interface IEmployeeRepository
    {
        void AddEmployee(EmployeeDataModel employeeDataModel);
        void DeleteEmployee(int employeeId);
        void UpdateEmployee(int employeeId, string dept,int salary);
        EmployeeDataModel? GetEmployee(int employeeId);
        List<EmployeeDataModel> GetEmployees();
    }
}
