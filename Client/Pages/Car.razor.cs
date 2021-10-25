using Microsoft.AspNetCore.Components;
using BlazorApp;
using BlazorApp.Shared;

namespace carProgram
{

    public class DoCar : ComponentBase
    {
        public string OutputMake { get; set; }
        public string OutputModel { get; set; }
        public string OutputColor { get; set; }
        public string OutputYear { get; set; }
        public string OutputPrice { get; set; }
        public string OutputMileage { get; set; }
        public string OutputURL { get; set; }
        public string OutputNotes { get; set; }
        string make;
        string model;
        string color;
        int year;
        string price;
        string URL;
        int mileage;
        string notes;

        public void Main()

        {
            DoCar Toyota = new DoCar();
            Toyota.make = "Toyota";
            Toyota.model = "Camry";
            Toyota.color = "Gray";
            Toyota.year = 2010;
            Toyota.price = "$5,650";
            Toyota.mileage = 74561;
            Toyota.URL = "https://media.ed.edmunds-media.com/toyota/camry/2010/oem/2010_toyota_camry_sedan_le_fq_oem_1_500.jpg";
            Toyota.notes = "";
            OutputMake = Toyota.make.ToString();
            OutputModel = Toyota.model.ToString();
            OutputColor = Toyota.color.ToString();
            OutputYear = Toyota.year.ToString();
            OutputPrice = Toyota.price.ToString();
            OutputMileage = Toyota.mileage.ToString();
            OutputURL = Toyota.URL.ToString();
            OutputNotes = Toyota.notes.ToString();
        }
    }
}