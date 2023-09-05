using System;

namespace VegetationApp
{
    public class ArithmeticOperations
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Add(int x, int y, int z)
        {
            return x + y + z;
        }

        public int Add(int x, int y, int z, int w)
        {
            return x + y + z + w;
        }
    }

    public class Vegetation
    {
        public int HeightVal { get; set; }
        public int Mass { get; set; }
        public int Spread { get; set; }

        public Vegetation(int heightVal, int mass) : this(heightVal, mass, 0) { }

        public Vegetation(int heightVal, int mass, int spread)
        {
            this.HeightVal = heightVal;
            this.Mass = mass;
            this.Spread = spread;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Height: {HeightVal}, Mass: {Mass}, Spread: {Spread}");
        }
    }

    class MainApp
    {
        static void Program()
        {
            ArithmeticOperations calculations = new ArithmeticOperations();
            Console.WriteLine(calculations.Add(2, 3));
            Console.WriteLine(calculations.Add(2, 3, 4));
            Console.WriteLine(calculations.Add(2, 3, 4, 5));

            Vegetation veg1 = new Vegetation(150, 2);
            Vegetation veg2 = new Vegetation(180, 3, 50);

            veg1.ShowDetails();
            veg2.ShowDetails();

            double[] numArray = new double[6];

            for (int i = 5; i <= 10; i++)
            {
                numArray[i - 5] = i;
                Console.WriteLine(numArray[i - 5]);
            }
        }

        static void Main()
        {
            Program();
        }
    }
}
