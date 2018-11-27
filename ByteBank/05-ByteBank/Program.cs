using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente gabriela = new Cliente(); // cria o objeto gabriela baseado na classe Cliente

            gabriela.nome = "Gabriela";
            gabriela.profissao = "Desenvolvedora C#";
            gabriela.cpf = "434.562.878-20";

            ContaCorrente conta = new ContaCorrente(); // cria o objeto conta baseado na classe ContaCorrente

            conta.titular = gabriela; // seta a conta.titular(que é uma referência ao objeto cliente) como o objeto gabriela. Isso é feito para vincular os dados entre as classes. 
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;

            Console.WriteLine(conta.titular.nome); // acessando o campo nome pelo objeto conta(classe ContaCorrente) que lá tem uma referência ao objeto Cliente
            Console.WriteLine(gabriela.nome); // acessando o campo nome pelo objeto gabriela(classe Cliente) diretamente.
                
        }
    }
}
