using Microsoft.AspNetCore.Components;
using BlazorApp;
using BlazorApp.Shared;

namespace inchesProgram
{
    public class Convert : ComponentBase
    {
        public double finalCentimeters { get; set; }
        public double finalFeet { get; set; }
        public double finalMiles { get; set; }
        public double userInput { get; set; }

        public double Cmconvert = 2.54; //conversion factor to convert inches to centimeters

        public double Ftconvert = 12; //conversion factor to convert inches to feet

        public double Mileconvert = 63360; //conversion factor to convert inches to miles

        public virtual void Calculator()
        {
            finalCentimeters = 0; //The default value of the page before an input is accepted.
            finalFeet = 0;
            finalMiles = 0;
        }
    }

    public class User : Convert
    {
        public override void Calculator()
        {
            finalCentimeters = userInput * Cmconvert;
            finalFeet = userInput / Ftconvert;
            finalMiles = userInput / Mileconvert;
        }

    }

    public class Program : User
    {
        private static void User()
        {
            Convert myInput = new Convert();
            myInput.Calculator();
        }


    }
}
