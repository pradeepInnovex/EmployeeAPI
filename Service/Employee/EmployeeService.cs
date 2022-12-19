using Models.Employee;
using ServiceInterface.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Employee
{
    public class EmployeeService : IEmployeePersonalData
    {
        public Task<EmployeePersonalData> DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<EmployeePersonalData>> GetAllEmployeeData()
        {
            throw new NotImplementedException();
        }

        public Task<List<EmployeePersonalData>> GetEmployeeListByCity(string city)
        {
            throw new NotImplementedException();
        }

        public Task<List<EmployeePersonalData>> GetEmployeeListByProvience(string provience)
        {
            throw new NotImplementedException();
        }

        public Task<List<EmployeePersonalData>> GetEmployeePersonalDataByID(string IdNumber)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeePersonalData> InsertEmployee()
        {
            throw new NotImplementedException();
        }

        public Task<EmployeePersonalData> UpdateEmployee(int id)
        {
            throw new NotImplementedException();
        }
    }
}
