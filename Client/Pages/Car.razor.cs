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

        public void Car1()

        {
            DoCar ToyotaCamry = new DoCar();
            ToyotaCamry.make = "Toyota";
            ToyotaCamry.model = "Camry";
            ToyotaCamry.color = "Gray";
            ToyotaCamry.year = 2010;
            ToyotaCamry.price = "$5,650";
            ToyotaCamry.mileage = 74561;
            ToyotaCamry.URL = "https://media.ed.edmunds-media.com/toyota/camry/2010/oem/2010_toyota_camry_sedan_le_fq_oem_1_500.jpg";
            ToyotaCamry.notes = "";
            OutputMake = ToyotaCamry.make.ToString();
            OutputModel = ToyotaCamry.model.ToString();
            OutputColor = ToyotaCamry.color.ToString();
            OutputYear = ToyotaCamry.year.ToString();
            OutputPrice = ToyotaCamry.price.ToString();
            OutputMileage = ToyotaCamry.mileage.ToString();
            OutputURL = ToyotaCamry.URL.ToString();
            OutputNotes = ToyotaCamry.notes.ToString();
        }
    }
}