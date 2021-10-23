using Microsoft.AspNetCore.Components;
using BlazorApp;
using BlazorApp.Shared;
using static System.Text.Encodings.Web.HtmlEncoder;

namespace carProgram
{

    public class DoCar : ComponentBase
    {
        public string OutputMake { get; set; }

        public string OutputModel { get; set; }

        public string OutputColor { get; set; }

        public string OutputYear { get; set; }

        public string OutputPrice { get; set; }

        string make;

        string model;

        string color;

        int year;

        string price;




        public void Camry()

        {
            DoCar Camry = new DoCar();

            Camry.make = "Toyota";

            Camry.model = "Camry";

            Camry.color = "Gray";

            Camry.year = 2010;

            Camry.price = "$5,650";

            OutputMake = Camry.make.ToString();
            OutputModel = Camry.model.ToString();
            OutputColor = Camry.color.ToString();
            OutputYear = Camry.year.ToString();
            OutputPrice = Camry.price.ToString();



        }

        public void MustangGT()

        {
            DoCar MustangGT = new DoCar();

            MustangGT.make = "Ford";

            MustangGT.model = "Mustang GT";

            MustangGT.color = "Black";

            MustangGT.year = 2018;

            MustangGT.price = "$29,975";

            OutputMake = MustangGT.make.ToString();
            OutputModel = MustangGT.model.ToString();
            OutputColor = MustangGT.color.ToString();
            OutputYear = MustangGT.year.ToString();
            OutputPrice = MustangGT.price.ToString();



        }
    }
}