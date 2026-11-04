using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RRHH.API.Entities;

namespace RRHH.API.Services.Employees
{
    public interface IEmployeeService// Una inerfasa nos ayuda a definir un contrato o varios, y clase que querramos use ese contrato
    {
        EmployeeEntity GetOneEmployee(int employee);
    }
}