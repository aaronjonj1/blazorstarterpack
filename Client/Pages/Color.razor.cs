using Microsoft.AspNetCore.Components;
using BlazorApp;
using BlazorApp.Shared;

namespace colorsProgram
{
    public class Color : ComponentBase
    {
        public string finalOutput { get; set; }
        public string userInput { get; set; }
        public virtual void colorCode()
        {
            finalOutput = "This is a color.";
        }
    }

    public class User : Color
    {
        public string finalOutput { get; set; }
        public string userInput { get; set; }
        public override void colorCode()
        {
            finalOutput = "This is the color " + userInput + ".";
        }

    }

    public class Program : User
    {
        public string finalOutput { get; set; }
        public string userInput { get; set; }
        public static void User()
        {
            Color myUser = new User();
            myUser.colorCode();
        }

    }
}
