using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6AnalisisGuia9
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.Title = "Programa que evalua 5 personas e imprime los nombres de las que son mayores de edad";

        string nombre1, nombre2, nombre3, nombre4, nombre5;
        Double edad1, edad2, edad3, edad4, edad5;

        Console.WriteLine("Ingrese el nombre:");
        nombre1 = Console.ReadLine();
        Console.WriteLine("Ingrese la edad:");
        edad1 = Double.Parse(Console.ReadLine());
        Console.WriteLine();
        
        Console.WriteLine("Ingrese el nombre:");
        nombre2 = Console.ReadLine();
        Console.WriteLine("Ingrese la edad:");
        edad2 = Double.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Ingrese el nombre:");
        nombre3 = Console.ReadLine();
        Console.WriteLine("Ingrese la edad:");
        edad3 = Double.Parse(Console.ReadLine());
        Console.WriteLine();
        
        Console.WriteLine("Ingrese el nombre:");
        nombre4 = Console.ReadLine();
        Console.WriteLine("Ingrese la edad:");
        edad4 = Double.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Ingrese el nombre:");
        nombre5 = Console.ReadLine();
        Console.WriteLine("Ingrese la edad:");
        edad5 = Double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Las personas mayores de edad son: ");
        if (edad1 >= 18)
        {
        Console.WriteLine(nombre1);    
        }

        if (edad2 >= 18)
        {
        Console.WriteLine(nombre2);    
        }

        if (edad3 >= 18)
        {
        Console.WriteLine(nombre3);    
        }

        if (edad4 >= 18)
        {
        Console.WriteLine(nombre4);    
        }

        if (edad5 >= 18)
        {
        Console.WriteLine(nombre5);    
        }

        if (edad1 < 18 && edad2 < 18 && edad3 < 18 && edad4 < 18 && edad5 < 18)
        {
        Console.WriteLine("Todas las personas son menores de edad.");    
        }
        

        Console.ReadKey();
        }
    }
}
