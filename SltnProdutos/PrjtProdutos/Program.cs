using System;

namespace PrjtProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeProduto;
            decimal valor, total, desc;
            int quant;



            //Receber o valor do produto;
            //Se maior que 3, verificar se há desconto;
            //Se o valor multiplicado pela quantidade menor que R$ 25,30, sem desconto;
            //Entre R$ 25,31 e R$ 150,00 - 10% desconto;
            //Acima de R$ 150,00 - 15% desconto;

            Console.WriteLine("Digite o produto desejado: ");
            nomeProduto = Console.ReadLine();
            Console.WriteLine("  ");

            Console.WriteLine("Digite a quantidade do produto: ");
            quant = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("  ");

            Console.WriteLine("Digite o valor do produto por unidade: ");
            valor = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("  ");

            total = (valor * quant);

            Console.WriteLine("O valor total é {0}", total);

            if (quant >= 3 && Convert.ToDouble(total) <= 25.30)
            {
                Console.WriteLine("Não há desconto para o valor");
            }

            else if (quant >= 3 && Convert.ToDouble(total) > 25.31 && Convert.ToDouble(total) < 150.00)
            {
                Console.WriteLine("Produto com 10% de desconto, total: " + total * 90 / 100);

            }
            else
            {
                Console.WriteLine("Produto com 15% de desconto, total: " + total * 85 / 100);
            }


















        }
    }
}
