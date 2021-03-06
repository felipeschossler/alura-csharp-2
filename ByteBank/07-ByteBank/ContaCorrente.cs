﻿namespace _07_ByteBank
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
        public int Agencia {
            get
            {
                return _agencia;
            }
            set
            {
                if(value <= 0)
                {
                    return;
                }

                _agencia = value;
            }
                
        }

        //método construtor que conta quantas contas foram criadas(ou seja quantas vezes o objeto foi instanciado)
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }

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

        //método TotalDeContasCriadas
        public static int TotalDeContasCriadas { get; private set; }

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