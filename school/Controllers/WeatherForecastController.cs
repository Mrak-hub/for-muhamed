using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace school.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class Procent : Controller
    {
        Calculator.Math clsMathtService = new Calculator.Math();
        [HttpGet("Sumnumbers")]
        public double  Get(double num1, int num2) {

          return  clsMathtService.Addition(num1, num2);
        }
        Calculator.Math clsMathService = new Calculator.Math();
        [HttpGet("Subtraction")]

        public double Add(double num1, double num2)
        {
            return clsMathService.Subtraction(num1, num2);
        }

        Calculator.Math clsMathService = new Calculator.Math();
        [HttpGet("Multiplication")]
        public double Add(double num1, double num2)
        {
            return clsMathService.Multiplication(num1, num2);
        }

    }
}   