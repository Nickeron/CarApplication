using System;

namespace CarApp
{
    public class Car
    {
        public string Brand { get; }
        public string Model { get; }
        public Engine CarEngine { get; set; }
        public Color CarColor { get; set; }
        public int Speed { get; set; }

        public Car(string brand, string model, string engineNum, Color color, int speed)
        {
            this.Brand = brand;
            this.Model = model;
            this.CarEngine = new Engine
            {
                EngineNumber = engineNum
            };
            this.CarColor = color;
            this.Speed = speed;
        }

        public void Accelerate(int newSpeed)
        {
            if (newSpeed > 120 || newSpeed <= 0)
            {
                Console.WriteLine("Illegal speed value!");
            }
            else if (newSpeed > this.Speed)
            {
                Console.WriteLine("Accelerating to "+ newSpeed.ToString() + "km/h");
                for (int i = this.Speed; i <= newSpeed; i++)
                {
                    Console.WriteLine(i.ToString() + "km/h");
                }
                this.Speed = newSpeed;
            }
            else
            {
                Console.WriteLine("Slowing down to " + newSpeed.ToString() + "km/h");
                for (int i = this.Speed; i >= newSpeed; i--)
                {
                    Console.WriteLine(i.ToString() + "km/h");
                }
                this.Speed = newSpeed;
            }
        }

        public void Stop()
        {
            this.Speed = 0;
        }

    }

    public class Engine
    {
        public string EngineNumber;
    }

    public enum Color
    {
        Red,
        Orange,
        NavyBlue
    }
}
