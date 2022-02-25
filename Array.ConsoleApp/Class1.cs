using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros.ConsoleApp
{
    public class Class1
    {
        static void Main(string[] args)
        {
            
            string NumeroLer = @"
     __  __      __  __  __  __  __  __ 
   | __| __||__||__ |__    ||__||__||  |
   ||__  __|   | __||__|   ||__| __||__|
    ";
            int contador = 0;
            System.IO.StringReader LeitorNumeros = new System.IO.StringReader(NumeroLer);
            string[] linhas = new string[4];
            linhas[0] = LeitorNumeros.ReadLine();
            linhas[1] = LeitorNumeros.ReadLine();
            linhas[2] = LeitorNumeros.ReadLine();
            linhas[3] = LeitorNumeros.ReadLine();
            string linhaParaLer = "";

            Console.WriteLine(linhas[1]);
            Console.WriteLine(linhas[2]);
            Console.WriteLine(linhas[3]);
            Console.WriteLine();
            volta:
            linhaParaLer = linhas[1].Substring(contador, 4) + linhas[2].Substring(contador, 4) + linhas[3].Substring(contador, 4);

            contador += 4; // cada numero ocupa 4 espaços
 

            switch (linhaParaLer)
            {
                case "    " +
                     "   |" +
                     "   |":
                    Console.Write(1);
                    break;

            case " __ " +
                 " __|" +
                 "|__ ":
                    Console.Write(2);
                    break;

                case " __ " +
                     " __|" +
                     " __|":
                    Console.Write(3);
                    break;

                case "    " +
                     "|__|" +
                     "   |":
                    Console.Write(4);
                    break;

                case " __ " +
                     "|__ " +
                     " __|":
                    Console.Write(5);
                    break;
                case " __ " +
                     "|__ " +
                     "|__|":
                    Console.Write(6);
                    break;

                case " __ " +
                     "   |" +
                     "   |":
                    Console.Write(7);
                    break;

                case " __ " +
                     "|__|" +
                     "|__|":
                    Console.Write(8);
                    break;

                case " __ " +
                     "|__|" +
                     " __|":
                    Console.Write(9);
                    break;

                case " __ " +
                     "|  |" +
                     "|__|":
                    Console.Write(0);
                    break;
            }

            if ((contador) < linhas[1].Length)
                goto volta;
            

            Console.ReadKey();

        }
    }
    


    
}
