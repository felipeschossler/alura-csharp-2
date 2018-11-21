using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03__ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contadaGabriela = new ContaCorrente();

            contadaGabriela.titular = "Gabriela";
            contadaGabriela.agencia = 863;
            contadaGabriela.numero = 863452;

            ContaCorrente contadaGabrielaCosta = new ContaCorrente();

            contadaGabrielaCosta.titular = "Gabriela";
            contadaGabrielaCosta.agencia = 863;
            contadaGabrielaCosta.numero = 863452;

            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idadeMaisUmaVez));
            Console.WriteLine("Igualdade de tipo de referência: " + (contadaGabriela == contadaGabrielaCosta));

            Console.WriteLine("Se as instancias do objeto forem igualadas ou seja contadaGabriela = contadaGabrielaCosta elas apontaram para o mesmo lugar na memória \n e assim " +
                "sempre terão o mesmos valores mesmo se apenas um objeto mudar de valor. ");

            Console.ReadLine();

        }
    }
}
