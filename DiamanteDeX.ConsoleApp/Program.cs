namespace DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número ímpar: ");

            int n = Convert.ToInt32(Console.ReadLine());

            while (n % 2 == 0)
            {
                Console.Write("Número Pár, informe um número ímpar: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
             
            for (int i = 0; i < n; i += 2)
            {

                for (int j = n; j > i; j -= 2)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k <= i; k += 1)
                {
                    Console.Write("x");
                    
                }

                Console.WriteLine();
            }

            for (int i = n - 2; i >= 0; i -= 2)
            {

                for (int j = n + 2; j > i; j -= 2)
                {
                    Console.Write(" ");
                }

                for (int k = i; k > 0; k -= 1)
                {
                    Console.Write("x");
                    
                }

                Console.WriteLine();
            }
        }
    }
}