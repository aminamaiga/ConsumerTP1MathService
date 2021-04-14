using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumerTP1MathService
{
    class Program
    {
        static void Main(string[] args)
        {
            MathServiceRef.MathService mathService = new MathServiceRef.MathService();

            Console.WriteLine("Bonjour je consomme le web service MATH pour affectuer un ensemble d'opération \n");

            Console.WriteLine(" Addition " + mathService.Add( 6, 9));
            Console.WriteLine(" Soustraction " + mathService.Add(16, 9));
            Console.WriteLine(" Division " + mathService.Add(26, 9));
            Console.WriteLine(" Multiplication " + mathService.Add(3, 9));

            Console.ReadLine();
        }
    }
}
