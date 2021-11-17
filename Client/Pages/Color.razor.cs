using Microsoft.AspNetCore.Components;
using BlazorApp;
using BlazorApp.Shared;

namespace colorsProgram
{
    public class Color : ComponentBase
    {
        public string finalOutput { get; set; }
        public virtual void colorCode()
        {
            finalOutput = "This is a color.";
        }
    }

    public class Red : Color
    {

        public override void colorCode()
        {
            finalOutput = "This is the color red.";
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
