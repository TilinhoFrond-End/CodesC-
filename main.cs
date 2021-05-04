using System;  
using System.Collections.Generic;  
using System.Linq; 
using System.Text;
using System.Threading.Tasks; 

namespace code
{
  class Program
  {
      static void Main(string[] args)
      {
          string nota1;
          string nota2;
          string nota3;
          string nota4;
          string nota5;
          int contador = 0;


          Console.WriteLine("Digite a nota 1: ");
          nota1 = Console.ReadLine();
          contador++;

          Console.WriteLine("Digite a nota 2: ");
          nota2 = Console.ReadLine();
          contador++;

          Console.WriteLine("Digite a nota 3: ");
          nota3 = Console.ReadLine();
          contador++;

          Console.WriteLine("Digite a nota 4: ");
          nota4 = Console.ReadLine();
          contador++;

          Console.WriteLine("Digite a nota 5: ");
          nota5 = Console.ReadLine();
          contador++;

          float nota_1 = float.Parse(nota1);
          float nota_2 = float.Parse(nota2);
          float nota_3 = float.Parse(nota3);
          float nota_4 = float.Parse(nota4);
          float nota_5 = float.Parse(nota5);
          float resultado = (nota_1+nota_2+nota_3+nota_4+nota_5) / contador;

          Console.WriteLine($"Média aritmética das {contador} notas: {resultado}.");
          
          Console.WriteLine();
      }
    }
}