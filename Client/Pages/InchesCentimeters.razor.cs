using Microsoft.AspNetCore.Components;
using BlazorApp;
using BlazorApp.Shared;

namespace centimetersProgram
{
    public class Convert : ComponentBase
    {
        public double finalOutput { get; set; }
        public double userInput { get; set; }

        public double convert = 2.54;

        public virtual void CentimetersCalculator()
        {
            finalOutput = 0;
        }
    }

    public class User : Convert
    {
        public override void CentimetersCalculator()
        {
            finalOutput = userInput * convert;
        }

    }

    public class Program : User
    {
        public static void User()
        {
            Convert myInput = new Convert();
            myInput.CentimetersCalculator();
        }


    }
}
