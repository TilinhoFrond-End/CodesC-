using System;  
using System.Collections.Generic;  
using System.Linq; 
using System.Text;
using System.Threading.Tasks;  


namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor1;
            int ano = 2050;

            Console.WriteLine("Digite o ano de nascimento: ");
            valor1 = Console.ReadLine();
            int valor_1 = int.Parse(valor1);

            int resultado = ano - valor_1;

            Console.WriteLine($"Sua idade é {resultado}");

            Console.ReadLine();
        }
    }
}
