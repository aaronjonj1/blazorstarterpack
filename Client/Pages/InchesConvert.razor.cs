using Microsoft.AspNetCore.Components;
using BlazorApp;
using BlazorApp.Shared;

namespace inchesProgram
{

    /// <summary>
    /// Convert Class, LO1, LO2, LO3, LO5
    /// </summary>
    public class Convert : ComponentBase
    {
        public double finalCentimeters { get; set; }
        public double finalFeet { get; set; }
        public double finalMiles { get; set; }
        public double userInput { get; set; }

        public double Cmconvert = 2.54; //conversion factor to convert inches to centimeters

        public double Ftconvert = 12; //conversion factor to convert inches to feet

        public double Mileconvert = 63360; //conversion factor to convert inches to miles

        /// <summary>
        /// Virtual Calculator
        /// </summary>
        public virtual void Calculator()
        {
            finalCentimeters = 0;
            finalFeet = 0;
            finalMiles = 0;
        }
    }
    
    /// <summary>
    /// User class that overrides the virtual function
    /// </summary>
    public class User : Convert
    {
        /// <summary>
        /// Overide Calculator
        /// </summary>
        public override void Calculator()
        {
            //convert userInput in inches to either centimeters, feet, or miles
            finalCentimeters = userInput * Cmconvert;
            finalFeet = userInput / Ftconvert;
            finalMiles = userInput / Mileconvert;
        }

    }

    /// <summary>
    /// Final Program Class
    /// </summary>
    public class Program : User
    {
        /// <summary>
        /// Output
        /// </summary>
        private static void User()
        {
            Convert myInput = new Convert();
            myInput.Calculator();
        }


    }
}
