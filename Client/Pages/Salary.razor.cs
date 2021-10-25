using System;

namespace SalaryProgram
{
    public class Average
    {
        public float salary = 51909;
    }
    public class Programmer : Average
    {
        public float programmerSalary = 95640;
    }
    class TestInheritance
    {
        public static void Main(string[] args)
        {
            Job p1 = new Programmer();

            Console.WriteLine("Average Salary: " + p1.salary);
            Console.WriteLine("Programmer Salary: " + p1.programmerSalary);

        }
    }
}