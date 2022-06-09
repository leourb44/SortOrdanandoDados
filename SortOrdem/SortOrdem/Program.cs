using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortOrdem
{
    internal class Program
    {
        static void OrdemNumeros ()
        {
			int[] numeros = new int[10];

			for (int i = 0; i < numeros.Length; i++)
			{
				Console.Write("Entre com um NÚMERO: ");

				numeros[i] = Convert.ToInt32(Console.ReadLine());
			}

			Array.Sort(numeros);
			Console.Write("s\n");
			foreach (int i in numeros) Console.WriteLine(i);
		}

		static void OrdemAlfabetica()
        {
			char[] letra = new char[5];

			for (int i = 0; i < letra.Length; i++) 
			{
				Console.Write("Entre com uma LETRA: ");
				letra[i] = Char.Parse(Console.ReadLine());
			}
			Array.Sort(letra);
			Console.Write(";\n");
			foreach (char i in letra) Console.WriteLine(i);

		}

		static void OrdemAlfabeticaPalavras()
		{
			string[] letra = new string[5];

			for (int i = 0; i < letra.Length; i++)
			{
				Console.Write("Entre com uma PALAVRA: ");
				letra[i] = (Console.ReadLine());
			}
			Array.Sort(letra);
			Console.Write(";\n");
			foreach (string i in letra) Console.WriteLine(i);

		}

		static void Main(string[] args)
        {

			int opc;
			int opc1 = 1;

			while (opc1 == 1) {

				Console.WriteLine("-------ESCOLHA COMO EXECUTAR-------");
				Console.WriteLine("Para realizar com NUMEROS digite 1;");
				Console.WriteLine("Para realizar com LETRAS digite 2;");
				Console.WriteLine("Para realizar com PALAVRAS digite 3;");
				opc = int.Parse(Console.ReadLine());

				if (opc == 1)
				{
					Program.OrdemNumeros();
				}
				else if (opc == 2)
				{
					Program.OrdemAlfabetica();
				}
				else if (opc == 3)
				{
					Program.OrdemAlfabeticaPalavras();
				}
				else
                {
					Console.WriteLine("Opção não encontrada, por favor tente novamente!");
                }

				Console.WriteLine("Precione 0 para sair e 1 para repeir: ");
				opc1 = int.Parse(Console.ReadLine());
			}
		}
    }
}
