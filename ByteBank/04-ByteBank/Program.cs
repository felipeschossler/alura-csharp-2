using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaDoFelipe = new ContaCorrente();
            contaDoFelipe.titular = "Felipe";
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";
            Console.WriteLine(contaDoBruno.saldo);
            contaDoBruno.Sacar(50);
            Console.WriteLine(contaDoBruno.saldo);
            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);

            Console.WriteLine("Saldo Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo Felipe: " + contaDoFelipe.saldo);

            contaDoBruno.Transferir(200, contaDoFelipe);

            Console.WriteLine("Saldo Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo Felipe: " + contaDoFelipe.saldo);

            Console.ReadLine();

        }
    }
}
