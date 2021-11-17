using Microsoft.AspNetCore.Components;
using BlazorApp;
using BlazorApp.Shared;

namespace colorsProgram
{
    public class Color : ComponentBase
    {
        public string userInput { get; set; }
        public string finalOutput { get; set; }
        public virtual void colorCode()
        {
            userInput = "";
            finalOutput = "This is a color.";
        }
    }

    public class Red : Color
    {

        public override void colorCode()
        {
            userInput = "red";
            finalOutput = "This is the color " + userInput + ".";
        }

    }

    public class Program : Red
    {
        public static void Red()
        {
            Color myRed = new Red();
            myRed.colorCode();
        }

    }
}
