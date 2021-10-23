using Microsoft.AspNetCore.Components;

namespace ConsoleApp3
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



        private void Main()

        {
            DoCar Toyota = new DoCar();

            Toyota.make = "Toyota";

            Toyota.model = "Camry";

            Toyota.color = "Gray";

            Toyota.year = 2010;

            Toyota.price = "$5,650";

            OutputMake = Toyota.make.ToString();
            OutputModel = Toyota.model.ToString();
            OutputColor = Toyota.color.ToString();
            OutputYear = Toyota.year.ToString();
            OutputPrice = Toyota.price.ToString();



        }
    }
}