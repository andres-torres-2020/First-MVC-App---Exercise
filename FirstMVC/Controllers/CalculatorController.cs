using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstMVC.Models; //added to reference Calculator class in Models folder
using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Calculator()
        {
            return View();
        }
        //when you build a new controller, the models aren't automatically brought over,
        //so you need to include a using namespaceNameblhblah.Models statement
        public IActionResult Calculate(Calculator calculator) //model binding
        {
            if (calculator.Operator == '+')
            {
                calculator.Result = calculator.Number1 + calculator.Number2;
            }
            else if (calculator.Operator == '-')
            {
                calculator.Result = calculator.Number1 - calculator.Number2;
            }
            else if (calculator.Operator == '*')
            {
                calculator.Result = calculator.Number1 * calculator.Number2;
            }
            else if (calculator.Operator == '/')
            {
                calculator.Result = calculator.Number1 / calculator.Number2;
            }
            return View("Calculator", calculator);
        }
    }
}