using Microsoft.AspNetCore.Components;
using BlazorApp;
using BlazorApp.Shared;
using System.IO;
using System.Text.Encodings.Web;
using static System.Console;
using static System.Text.Encodings.Web.HtmlEncoder;
using System;

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
        public override void colorCode()
        {
            finalOutput = "This is the color " + userInput + ".";
        }

    }

    public class Program : ComponentBase
    {
        public string userInput { get; set; }
        public string finalOutput { get; set; }
        public static void Main()
        {
            Color myColor = new Color();
            myColor.colorCode();

            Color myUser = new User();
            myUser.colorCode();
        }

    }
}
