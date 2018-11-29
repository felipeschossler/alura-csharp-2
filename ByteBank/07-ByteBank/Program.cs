using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            //o método construtor nada mais que que um método que obriga a criação de um objeto de uma determinada maneira, afim de evitar erros, basicamente.

            //utilizando o método construtor
            ContaCorrente conta = new ContaCorrente(867, 86712540);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();

        }
    }
}
