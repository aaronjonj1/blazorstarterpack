using Microsoft.AspNetCore.Components;
using BlazorApp;
using BlazorApp.Shared;

namespace carProgram
{

    //main class (the parent class)
    public class DoCar : ComponentBase
    {

        public string make; //car make
        public string model; //car model
        public string color; //car color
        public int year; //car year
        public string price; //car price
        public string URL; //car url
        public int mileage; //car mileage
        public string notes; //car notes

        //Outputs
        public string OutputMake { get; set; }
        public string OutputModel { get; set; }
        public string OutputColor { get; set; }
        public string OutputYear { get; set; }
        public string OutputPrice { get; set; }
        public string OutputMileage { get; set; }
        public string OutputURL { get; set; }
        public string OutputNotes { get; set; }
    }

    //sub class

    //inherits the parent class making this a child class
    public class AllCars : DoCar
    {
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

        public void Car3()

        {
            DoCar VWTiguan = new DoCar();
            VWTiguan.make = "Volkswagen";
            VWTiguan.model = "Tiguan";
            VWTiguan.color = "Blue";
            VWTiguan.year = 2017;
            VWTiguan.price = "$22,475";
            VWTiguan.mileage = 64593;
            VWTiguan.URL = "https://media.ed.edmunds-media.com/volkswagen/tiguan/2017/oem/2017_volkswagen_tiguan_4dr-suv_wolfsburg-edition-4motion_fq_oem_1_1600.jpg";
            VWTiguan.notes = "";
            OutputMake = VWTiguan.make.ToString();
            OutputModel = VWTiguan.model.ToString();
            OutputColor = VWTiguan.color.ToString();
            OutputYear = VWTiguan.year.ToString();
            OutputPrice = VWTiguan.price.ToString();
            OutputMileage = VWTiguan.mileage.ToString();
            OutputURL = VWTiguan.URL.ToString();
            OutputNotes = VWTiguan.notes.ToString();
        }

         public void Car4()

        {
            DoCar KiaRio = new DoCar();
            KiaRio.make = "Kia";
            KiaRio.model = "Rio";
            KiaRio.color = "White";
            KiaRio.year = 2015;
            KiaRio.price = "$12,479";
            KiaRio.mileage = 83923;
            KiaRio.URL = "https://bidfax.info/uploads/posts/2018-12/14/kia-rio-2015-knadm4a33f6501926-img1.jpg";
            KiaRio.notes = "May need to buy a new battery.";
            OutputMake = KiaRio.make.ToString();
            OutputModel = KiaRio.model.ToString();
            OutputColor = KiaRio.color.ToString();
            OutputYear = KiaRio.year.ToString();
            OutputPrice = KiaRio.price.ToString();
            OutputMileage = KiaRio.mileage.ToString();
            OutputURL = KiaRio.URL.ToString();
            OutputNotes = KiaRio.notes.ToString();
        }

        public void Car5()

        {
            DoCar FordTruck = new DoCar();
            FordTruck.make = "Ford";
            FordTruck.model = "F-150";
            FordTruck.color = "Black";
            FordTruck.year = 2013;
            FordTruck.price = "$13,899";
            FordTruck.mileage = 122003;
            FordTruck.URL = "https://bidfax.info/uploads/posts/2020-08/13/ford-f-150-2013-1ftfw1et3dke41844-img1.jpg";
            FordTruck.notes = "";
            OutputMake = FordTruck.make.ToString();
            OutputModel = FordTruck.model.ToString();
            OutputColor = FordTruck.color.ToString();
            OutputYear = FordTruck.year.ToString();
            OutputPrice = FordTruck.price.ToString();
            OutputMileage = FordTruck.mileage.ToString();
            OutputURL = FordTruck.URL.ToString();
            OutputNotes = FordTruck.notes.ToString();
        }

        public void Car6()

        {
            DoCar PTCruiser = new DoCar();
            PTCruiser.make = "Chrysler";
            PTCruiser.model = "PT Cruiser";
            PTCruiser.color = "White";
            PTCruiser.year = 2006;
            PTCruiser.price = "$3,940";
            PTCruiser.mileage = 117734;
            PTCruiser.URL = "https://static.cargurus.com/images/forsale/2021/03/31/20/46/2006_chrysler_pt_cruiser-pic-545578003520412230-1024x768.jpeg";
            PTCruiser.notes = "Convertible";
            OutputMake = PTCruiser.make.ToString();
            OutputModel = PTCruiser.model.ToString();
            OutputColor = PTCruiser.color.ToString();
            OutputYear = PTCruiser.year.ToString();
            OutputPrice = PTCruiser.price.ToString();
            OutputMileage = PTCruiser.mileage.ToString();
            OutputURL = PTCruiser.URL.ToString();
            OutputNotes = PTCruiser.notes.ToString();
        }
    }
}