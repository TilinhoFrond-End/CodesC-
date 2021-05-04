using System;  
using System.Collections.Generic;  
using System.Linq; 
using System.Text;
using System.Threading.Tasks;  


namespace Code10
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor1;
            string valor2;
            string valor3;
            string valor4;
            string valor5;

            Console.WriteLine("Digite o valor 1:");
            valor1 = Console.ReadLine();
            int valor_1 = int.Parse(valor1);
            Console.WriteLine("Digite o valor 2:");
            valor2 = Console.ReadLine();
            int valor_2 = int.Parse(valor2);
            Console.WriteLine("Digite o valor 3:");
            valor3 = Console.ReadLine();
            int valor_3 = int.Parse(valor3);
            Console.WriteLine("Digite o valor 4:");
            valor4 = Console.ReadLine();
            int valor_4 = int.Parse(valor4);
            Console.WriteLine("Digite o valor 5:");
            valor5 = Console.ReadLine();
            int valor_5 = int.Parse(valor5);


            if ((valor_1 > valor_2) && (valor_1 > valor_3) && (valor_1 > valor_4) && (valor_1 > valor_5))
                Console.WriteLine("O maior valor é o 1º");
            if ((valor_2 > valor_1) && (valor_2 > valor_3) && (valor_2 > valor_4) && (valor_2 > valor_5))
                Console.WriteLine($"O maior valor é o 2º");
            if ((valor_3 > valor_1) && (valor_3 > valor_2) && (valor_3 > valor_4) && (valor_3 > valor_5))
                Console.WriteLine("O maior valor é o 3º");
            if ((valor_4 > valor_1) && (valor_4 > valor_2) && (valor_4 > valor_3) && (valor_4 > valor_5))
                Console.WriteLine("O maior valor é o 4º");
            if ((valor_5 > valor_1) && (valor_5 > valor_2) && (valor_5 > valor_3) && (valor_5 > valor_4))
                Console.WriteLine("O maior valor é o 5º");

            Console.ReadLine();
        }
    }
}