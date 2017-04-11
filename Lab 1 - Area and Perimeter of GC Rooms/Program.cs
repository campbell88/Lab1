using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1___Area_and_Perimeter_of_GC_Rooms
{
    class Program
    {
        static void Main(string[] args)
        {
            bool askToContinue = false; // do while to ask user to continue
            do
            {
                Console.WriteLine("Enter Length of Room:");
                double length = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Width of Room:");
                double width = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Height of Room:");
                double height = double.Parse(Console.ReadLine());

                double area = length * width;
                double perimeter = 2 * (length + width);
                double volume = length * width * height;
                

                Console.WriteLine("Area of room is {0} and Perimeter of room is {1} and Volume is {2}", area, perimeter, volume);
                
                Console.WriteLine("Type YES to continue"); 

                if (Console.ReadLine().ToUpper() == "YES") // removed the semicolon          
                    askToContinue = true;
                
            } while (askToContinue);







        }
    }
}
