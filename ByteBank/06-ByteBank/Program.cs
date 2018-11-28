using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //nesta aula foi evidenciado o conceito de encapsulamento e o benefício do uso de getters e setters ao invés de alterar os campos diretamente, pois temos mais poder para 
            //validá-los e manipulá-los.
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            //iniciando variáveis para serem usadas no WriteLine conta.titular.Nome
            cliente.Nome = "Guilherme";
            cliente.Cpf = "434.564.879-20";
            cliente.Profissao = "Desenvolvedor";

            conta.Titular = cliente;
            conta.Saldo = -10;//não funciona, pois a lógica do setter impede isso.

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);

            Console.ReadLine();

        }
    }
}
