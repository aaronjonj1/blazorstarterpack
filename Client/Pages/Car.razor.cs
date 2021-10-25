using Microsoft.AspNetCore.Components;


namespace carProgram
{

    public class DoCar : ComponentBase
    {
        public string OutputMake;

        public string OutputModel;

        public string OutputColor;

        public string OutputYear;

        public string OutputPrice;


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

            OutputMake = make.ToString();
            OutputModel = model.ToString();
            OutputColor = color.ToString();
            OutputYear = year.ToString();
            OutputPrice = price.ToString();
      


        }

        public void MustangGT()

        {
            DoCar MustangGT = new DoCar();

            MustangGT.make = "Ford";

            MustangGT.model = "Mustang GT";

            MustangGT.color = "Black";

            MustangGT.year = 2018;

            MustangGT.price = "$29,975";

            OutputMake = make.ToString();
            OutputModel = model.ToString();
            OutputColor = color.ToString();
            OutputYear = year.ToString();
            OutputPrice = price.ToString();



        }
    }
}