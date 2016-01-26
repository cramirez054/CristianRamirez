using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3_Estudiante
{
    class Program
    {
        static void Main(string[] args)
        {

            // Call the constructor that has no parameters.
            Estudiante person1 = new Estudiante();
            Console.WriteLine(person1.name);
            person1.SetName("John Smith");
            Console.WriteLine(person1.name);
            // Call the constructor that has one parameter.
            Estudiante person2 = new Estudiante("Sarah Jones");
            Console.WriteLine(person2.name);
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
