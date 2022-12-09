using System;

namespace PrjtHelloWorldMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Receber 2 notas e extrair a média.
            //Se maior que 7, aprovado. Se menor, reprovado.

            decimal n1, n2, media;

            Console.WriteLine("Digite a 1ª nota: ");
            n1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("  ");

            Console.WriteLine("Digite a 2ª nota: ");
            n2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("  ");

            media = (n1 + n2) / 2;

            Console.WriteLine("A média do aluno é {0}", media);
            Console.WriteLine("  ");

            if (media < 7)
            {
                Console.WriteLine("Aluno Reprovado!");
            }
            else
            {
                Console.WriteLine("Aluno Aprovado!");
            }    


        }
    }
}
