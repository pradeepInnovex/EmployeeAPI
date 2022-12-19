using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Employee;
using ServiceInterface.Employee;

namespace EmployeeAPI.Controllers.Employee
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeePersonalDataController : ControllerBase
    {

        private readonly IEmployeePersonalData _employeePersonalData;
        
        public EmployeePersonalDataController(IEmployeePersonalData employeePersonalData)
        {
            _employeePersonalData = employeePersonalData;

        }

        [HttpGet]
        public async Task<ActionResult<List<EmployeePersonalData>>> GetAllEmployeeData()
        {
            var employee =  await _employeePersonalData.GetAllEmployeeData();
            return Ok(employee);

        }

        [HttpGet("{city}")]
        public async Task<ActionResult<List<EmployeePersonalData>>> GetEmployeeListByCity(string city)
        {
            var employee2 = await _employeePersonalData.GetEmployeeListByCity(city);

            if (employee2 is null)
            {
                return BadRequest("Not Fount");
            }

            else
            {
                return Ok(employee2);
            }

        }

        [HttpGet("{provience}")]
        public async Task<ActionResult<List<EmployeePersonalData>>> GetEmployeeListByProvience(string provience)
        {
            var provienceList = await _employeePersonalData.GetEmployeeListByProvience(provience);

            if (provienceList is null)
            {
                return BadRequest("Data Not Available");
            }
            else
            {
                return Ok(provienceList);
            }

        }


        [HttpGet("{IdNumber}")]
        public async Task<ActionResult<List<EmployeePersonalData>>> GetEmployeePersonalDataByID(string IdNumber)
        {
            var idNumList = await _employeePersonalData.GetEmployeePersonalDataByID(IdNumber);

            if (idNumList is null)
            {
                return BadRequest("Data Not Available...");

            }

            else
            {
                return Ok(idNumList);
            }
        }

        [HttpPost]
        public async Task<ActionResult<EmployeePersonalData>> InsertEmployee()
        {
            var inser = await _employeePersonalData.InsertEmployee();
            return Ok(inser);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<EmployeePersonalData>>UpdateEmployee(int id)
        {
            var update = await _employeePersonalData.UpdateEmployee(id);
            return Ok(update);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<EmployeePersonalData>> DeleteEmployee(int id)
        {
            var del = await _employeePersonalData.DeleteEmployee(id);
            return Ok(del);
        }


    }
}
