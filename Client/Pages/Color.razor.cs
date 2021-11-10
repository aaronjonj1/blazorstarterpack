using Microsoft.AspNetCore.Components;
using BlazorApp;
using BlazorApp.Shared;
using System.IO;
using System.Text.Encodings.Web;
using static System.Console;
using static System.Text.Encodings.Web.HtmlEncoder;
using System;

namespace colorProgram
{
    public class Color
    {
        public virtual void colorCode()
        {
            Console.WriteLine("This is a color.");
        }
    }

    public class Red : Color
    {
        public override void colorCode()
        {
            Console.WriteLine("This is the color red.");
        }
    }

    public class Blue : Color
    {
        public override void colorCode()
        {
            Console.WriteLine("This is the color blue.");
        }
    }

    public class Program
    {
        string FinalOutput;
        public static void Main()
        {
            Color myColor = new Color();
            myColor.colorCode();

            Color myRed = new Red();
            myRed.colorCode();

            Color myBlue = new Blue();
            myBlue.colorCode();
        }

            
        
    }
}
