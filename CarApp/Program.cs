using System;

namespace CarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Lambo = new Car("Lamborghini", "Morcielagro", "df23faeg", Color.NavyBlue, 0 );
            Lambo.Accelerate(100);
            Lambo.Accelerate(50);
            Lambo.Stop();
            Console.WriteLine("So all in all we have a " + Lambo.CarColor + " "
                + Lambo.Brand + " " + Lambo.Model + " with engine No: "
                + Lambo.CarEngine.EngineNumber);

            Console.ReadKey();
        }
    }
}
