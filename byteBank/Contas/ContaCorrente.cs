using bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        // geters & seters
        public static int TotalDeContasCriadas { get; private set; }

        private int numero_agencia;
        public int Numero_agencia
        {
            get { return this.numero_agencia; }
            private set {
                if (value > 0) {
                    this.numero_agencia = value; 
                }
            }
        }
        public string Conta { get; set; }
        private double saldo;
        public double Saldo 
        { 
            get { 
                return saldo;
            }
            set {
                if (value > 0)
                {
                    this.saldo = value;
                }
            }
        }

        public Cliente Titular { get; set;}

        // Construtor
        public ContaCorrente(int numero_agencia, string numero_conta)
        {
            this.Numero_agencia = numero_agencia;
            this.Conta = numero_conta;
            TotalDeContasCriadas++;
        }

        //Metodos
        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {

                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }



    }
}