using System;

namespace PrjtMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int faltas;
            decimal n1, n2, n3, n4, media, notaRec = 0;


            Console.WriteLine("Desempenho do aluno");
            Console.WriteLine("");
            Console.WriteLine("Nome do aluno: ");
            nome = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Nota do 1º Bimestre:");
            n1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Nota do 2º Bimestre:");
            n2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Nota do 3º Bimestre:");
            n3 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Nota do 4º Bimestre:");
            n4 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Número de dias faltados:");
            faltas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            media = (n1 + n2 + n3 + n4) / 4;

            if (faltas >= 91)
            {
                Console.WriteLine("Aluno Excedeu o Limite de Faltas - REPROVADO");
            }
            else if (media < 5)
            {
                Console.WriteLine("Nota Abaixo da Média - REPROVADO");
            }
            else if (media < 7)
            {
                Console.WriteLine("Nota Entre a Média - RECUPERAÇÃO");
            }
            else if (media > 7)
            {
                Console.WriteLine("Nota Acima da Média - APROVADO");
            }
            if (media < 7 && media > 5 && faltas < 92)
            {
                Console.WriteLine("Solicitar Nova Nota:");
                notaRec = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("");

                if (notaRec >= 7)
                {
                    Console.WriteLine("Aluno Aprovado na REC");

                }
                else
                Console.WriteLine("Aluno Reprovado na REC");
            }
        }
    }
}
