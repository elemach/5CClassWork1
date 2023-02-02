using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5CClassWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] edad = new int[] { 20, 22, 33 };
            int[] salarios = new int[] { 200, 300, 150 };
            string[] musico = new string[3];
            musico[0] = "Ringo";
            musico[1] = "Paul";
            musico[2] = "John";

            for (int i = 0; i < musico.Length; i++)
            {
                Console.WriteLine(musico[i] + " tiene " + edad[i] + " años y un salario de: " + salarios[i] + " con un IVA de: "
                    + (salarios[i]*0.13) + " para un total de: " + (salarios[i] * 0.13 + salarios[i]) + " con IVA incluido.");
            }
            Console.ReadLine();
        }
    }
}
