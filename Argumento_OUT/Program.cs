using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argumento_OUT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dividendo = 10, divisor = 3, quociente, resto;
            quociente = Divide(dividendo, divisor, out resto);
            Console.WriteLine("{0}/{1} quociente = {2} resto = {3}", dividendo, divisor, quociente, resto);
            Console.ReadKey();
        }
        static int Divide(int dividendo, int divisor, out int resto)
        {
            int quociente = dividendo / divisor;
            resto = dividendo % divisor;
            return quociente;
        }
    
    }
}
