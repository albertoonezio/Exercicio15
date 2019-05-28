using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = ""; //Alberto Martins Onezio
            Console.Write("Digite seu Nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Todo o Nome: {0}", nome);
            Console.WriteLine("Primeiro Caracter: {0}", nome.Substring(0, 1));
            Console.WriteLine("Quantidade de Caracter: {0}", nome.Length);
            Console.WriteLine("Último Caracter: {0}", nome.Substring(nome.Length - 1, 1));
            Console.WriteLine("Do Primeiro ate o Terceiro: {0}", nome.Substring(0, 3));
            Console.WriteLine("O Quarto Caracter: {0}", nome.Substring(3, 1));
            Console.WriteLine("Todos menos o Primeiro: {0}", nome.Substring(1, nome.Length - 1));
            Console.WriteLine("Os dois Último: {0}", nome.Substring(nome.Length - 2, 2));
        }
    }
}
