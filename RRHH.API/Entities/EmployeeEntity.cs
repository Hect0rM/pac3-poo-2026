using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RRHH.API.Entities
{
    public class EmployeeEntity : BaseEntity
    {
        public string? FirstName{ get; set; } //se definen asi si son propiedades
        public string? LastName{ get; set; }

        public string? DNI { get; set; }

        public string? Gender { get; set; }

        // x = FirstName; <--- get
        //FirstName = "Juan" <--- set
    }
}