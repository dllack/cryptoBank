using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBank
{
    class ContaCorrente
    {
        public string titular;
        public int agencia;
        public int numero;
        public double saldo;


        public bool Sacar(double valor) {
            if (this.saldo < valor)
            {
                return false;
            }

            else {
                this.saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor) {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino){
            if (this.saldo < valor)
            {
                return false;
            }

            else 
            {
                this.saldo -= valor;
                contaDestino.saldo += valor;
                return true;
            }
        }
    }
}
