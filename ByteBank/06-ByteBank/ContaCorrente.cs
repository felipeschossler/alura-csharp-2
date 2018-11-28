// using _05_ByteBank;

namespace _06_ByteBank
{
    public class ContaCorrente
    {
        //declaração dos campos
        private Cliente _titular;
        private int _agencia;
        private int _numero;
        private double _saldo = 100;

        //método Titular que referencia a classe(objeto) Cliente
        public Cliente Titular{ get; set;}
           
        //método Agencia
        public int Agencia { get; set; }
        //método Número
        public int Numero { get; set; }

        //método Saldo
        public double Saldo
        {
            get
            {
                return _saldo;
            }

            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        //método Sacar
        public bool Sacar(double valor)
        {
            if (this._saldo <= valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }
        }

        //método Depositar
        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        //método Transferir
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo <= valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }


}