using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RRHH.API.Controllers
{
    public class CalculatorController 
    {
        [ApiController]
        [Route("api/calculator")]

        public class Calculator : ControllerBase
        {
            [HttpPost]
            public IActionResult Operators([FromBody] CalculatorModel calculator)
            {
                int result = calculator.Operator switch
                {
                    "+" => calculator.N1 + calculator.N2,
                    "-" => calculator.N1 - calculator.N2,
                    "x" => calculator.N1 * calculator.N2,
                    "/" => calculator.N1 / calculator.N2,
                    _ => 0
                };

                return Ok( new
                {
                    N1 = calculator.N1,
                    N2 = calculator.N2,
                    Operator = calculator.Operator,

                    Total = result
                }
                );
            }
        }
    }
    public class CalculatorModel
    {
        public int N1 { get; set; }

        public int N2 { get; set; }

        public string? Operator { get; set; }
    }
}