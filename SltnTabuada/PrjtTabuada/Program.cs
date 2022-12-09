using System;

namespace PrjtTabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, cont=0, tabuada;


            Console.WriteLine("TABUADA");
            Console.WriteLine("  ");
            Console.WriteLine("Digite a Tabuada que deseja ver: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tabuada com o do..while");
            Console.WriteLine("-x-x-x-x-x-x-x-x-x-x-x-");
            Console.WriteLine("   ");
            
            do
            {
                Console.WriteLine($" {numero} X {cont} = {numero * cont}");
                cont = cont + 1;

            } while (cont <= 10);

            Console.WriteLine("\nTABUADA");            
            Console.WriteLine("Digite a Tabuada que deseja ver: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tabuada com o while");
            Console.WriteLine("\n-x-x-x-x-x-x-x-x-x-x-x-");
            
            cont = 0;
            while (cont <= 10)
            {
                Console.WriteLine($" {numero} X {cont} = {numero * cont}");
                cont = cont + 1;
            }

            Console.WriteLine("\nTABUADA");
            Console.WriteLine("Digite a Tabuada que deseja ver: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tabuada com o for");
            Console.WriteLine("\n-x-x-x-x-x-x-x-x-x-x-x-");

            for (cont = 0;  //1a parte - cria a variavel e/ou atribui o valor
                cont <= 10; //2a parte - condição de guarda 🐶
                cont++)     //3a parte - incremento ou decremento (--)
            {

            }
        }
    }
}
