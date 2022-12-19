using Models.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceInterface.Employee
{
    public interface IEmployeePersonalData
    {
        Task<List<EmployeePersonalData>> GetAllEmployeeData();

        Task<List<EmployeePersonalData>> GetEmployeePersonalDataByID(string IdNumber);

        Task<List<EmployeePersonalData>> GetEmployeeListByProvience(string provience);

        Task<List<EmployeePersonalData>> GetEmployeeListByCity(string city);

        Task<EmployeePersonalData> DeleteEmployee(int id);

        Task<EmployeePersonalData> UpdateEmployee(int id);

        Task<EmployeePersonalData> InsertEmployee();
    }
}
