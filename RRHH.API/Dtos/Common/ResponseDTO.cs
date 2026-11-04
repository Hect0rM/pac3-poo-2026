using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RRHH.API.Dtos.Common
{
    public class ResponseDTO<T>//esto signifaca que ResposeDTO apartir de la plantilla va a ser un valor generico
    {
        public int StatusCode{ get; set; }
        public bool Status{ get; set; }

        public string? Message{ get; set; }

        public T? Data{ get; set; }
    }
}