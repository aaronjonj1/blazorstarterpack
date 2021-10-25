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

        public void Car2()

        {
            DoCar NissanAltima = new DoCar();
            NissanAltima.make = "Nissan";
            NissanAltima.model = "Altima";
            NissanAltima.color = "Blue";
            NissanAltima.year = 2004;
            NissanAltima.price = "$2,758";
            NissanAltima.mileage = 103568;
            NissanAltima.URL = "https://hips.hearstapps.com/autoweek/assets/s3fs-public/60630006.jpg";
            NissanAltima.notes = "Back right side of car damaged.";
            OutputMake = NissanAltima.make.ToString();
            OutputModel = NissanAltima.model.ToString();
            OutputColor = NissanAltima.color.ToString();
            OutputYear = NissanAltima.year.ToString();
            OutputPrice = NissanAltima.price.ToString();
            OutputMileage = NissanAltima.mileage.ToString();
            OutputURL = NissanAltima.URL.ToString();
            OutputNotes = NissanAltima.notes.ToString();
        }
    }
}