using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RRHH.API.Entities;

namespace RRHH.API.Controllers
{
    [Route("api/employees")]//esta es la ruta que se usa
    [ApiController]//aqui demuestro que es un controlador de API
    public class EmployeesControlles : ControllerBase
    {
        private readonly List<EmployeeEntity> _employees;

// el metodo contructor tiene que si o si ser public y se debe llamar a la clase
        public EmployeesControlles()//se va a activar la instancia, se crea una clase de un solo
        {
            _employees = new List<EmployeeEntity>();

            _employees.Add(new EmployeeEntity{ Id = 1, FirstName = "Juan", LastName = "Perez", DNI = "0401-2000-00001", Gender = "M"});
            _employees.Add(new EmployeeEntity{ Id = 2, FirstName = "Maria", LastName = "Rodrigez", DNI = "0401-2000-00002", Gender = "F"});

        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_employees);
        }

        [HttpGet("{dni}")]//esto es para poner un parametro osea en la direcion espesifica
        public IActionResult GetOne(string dni)//esto para recorrer y buscar a uno en espesifico
        {
            //EmployeeEntity emp = new EmployeeEntity();
            //foreach (var employee in _employees)
            //{
            //    if(employee.DNI != null && employee.DNI.Equals(dni))
            //    {
            //        emp = employee;
            //    }
            //}

            var emp = _employees.FirstOrDefault(e => e.DNI == dni);

            return Ok(emp);// se puede poner asi(_employees.FirstOrDefault(e => e.DNI == dni);) y no poner lo de arriba
        }

        [HttpPost]
        public IActionResult Post([FromBody] EmployeeEntity employee)
        {
            _employees.Add(employee);

            return Ok(new{id = employee.Id});
        }

        //put es completa un parche completo y PATCH es PARCIAL

        [HttpPut("{dni}")]
        public IActionResult Put( string dni, [FromBody] EmployeeEntity employee )
        {
            var oldEmployee = _employees.FirstOrDefault(e => e.DNI == dni);

            if (oldEmployee != null)
            {
                _employees.Remove(oldEmployee);
                _employees.Add(employee);
            }

            return Ok(_employees);
        }

        [HttpDelete("{dni}")]

        public IActionResult Delete(string dni)
        {
            var oldEmployee = _employees.FirstOrDefault(e => e.DNI == dni);

            if(oldEmployee != null)
            {
                _employees.Remove(oldEmployee);
            }

            return Ok(_employees);
        }

        
    }
}