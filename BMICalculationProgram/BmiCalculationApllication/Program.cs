using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiCalculationApllication
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = UserInputReadFromConsoleLib.UserInputReadFromConsoleType.GetUserHeight();
            int weight = UserInputReadFromConsoleLib.UserInputReadFromConsoleType.GetUserWeight();

            int bmiValue=BmiValueCalculationLib.BmiValueCalculationType.calculator(height, weight);

            string message = BmiValueValidatorLib.BmiValueValidatorType.CheckCondition(bmiValue);

            ConsoleMessageDisplayLib.ConsoleMessageDisplayType.Display(message);
            
            

        }
    }
}
