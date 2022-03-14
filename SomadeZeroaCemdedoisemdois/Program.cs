using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomadeZeroaCemdedoisemdois
{
    public class Program
    {
        static void Main()
        {
            int soma = 0;
            for (int i = 0; i <= 100; i += 2) 
            {
                soma += i;
            }
            Console.WriteLine(soma);
            Console.ReadKey();


        }
    }
}
