using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RRHH.API.Entities
{
    public class BaseEntity
    {
        public Guid Id {get; set;}
        public string? FirstName{ get; set; } //se definen asi si son propiedades
        public string? LastName{ get; set; }

        public string? FullName { get => $"{FirstName} {LastName}"; }//Solo para mostrar por eso se quita el SET

        public string? DNI { get; set; }

        public string? Gender { get; set; }
       
    }
}