using System;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Which monnument would you like to work with? ");
            string building = Console.ReadLine();

            switch (building.ToLower())
            {
                case "teotihuacan":
                    CalculateTotalCost();
                    break;

                case "taj mahal":
                    CalculateTotalCostTM();
                    break;

                case "great mosque of mecca":
                    CalculateTotalCostGMM();
                    break;
                default:
                    Console.WriteLine("Monument not recognized");
                    break;

            }
        }

        static double Rect(double length, double width)
        {
            double area = length * width;
            return area;
        }

        static double Circle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        static double Triangle(double bottom, double height)
        {
            double area = 0.5 * bottom * height;
            return area;
        }
        static void CalculateTotalCost()
        {
            double length = 2500;
            double width = 1500;
            double radius = (0.5 * 375);
            double bottom = 750;
            double height = 500;

            double rectArea = Rect(length, width);
            double circArea = 0.5 * Circle(radius);
            double triArea = Triangle(bottom, height);
            double totalArea = rectArea + circArea + triArea;
            double cost = Math.Round((totalArea * 180), 2);

            Console.WriteLine($"The total cost of the flooring material is {cost} pesos!");
        }

        static void CalculateTotalCostGMM()
        {
            double length = (284 + 106);
            double width = 264;
            double bottom = 84;
            double height = 264;
            double length1 = (0.5 * (264 - 180));
            double width1 = 106;

            double rectArea = Rect(length, width);
            double rectArea1 = Rect(length1, width1);
            double triArea = Triangle(bottom, height);
            double totalArea = rectArea - (rectArea1 * 2) - triArea;
            double cost = Math.Round((totalArea * 180), 2);

            Console.WriteLine($"The total cost of the flooring material is {cost} pesos!");
        }

        static void CalculateTotalCostTM()
        {
            double length = 90.5;
            double width = 90.5;
            double bottom = 24;
            double height = 24;

            double rectArea = Rect(length, width);
            double triArea = Triangle(bottom, height);
            double totalArea = rectArea - (triArea * 4);
            double cost = Math.Round((totalArea * 180), 2);

            Console.WriteLine($"The total cost of the flooring material is {cost} pesos!");
        }
    }
}
