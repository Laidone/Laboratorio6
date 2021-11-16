using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6
{
    public abstract class Conta
    {
        private decimal saldo;
        private string titular;
        private int cont_Saque = 0;
        private int cont_Deposito = 0;
        public Conta(string t)
        {
            titular = t;
        }
        public decimal Saldo
        {
            get { return saldo; }
        }
        public string Titular
        {
            get { return titular; }
        }
        public abstract string Id
        {
            get;
        }
        public virtual void Depositar(decimal valor)
        {
            saldo += valor;
            ++cont_Deposito;

        }
        public int deposito
        {
            get { return cont_Deposito; }
        }
        public int saque
        {
            get { return cont_Saque; }
        }
        public virtual void Sacar(decimal valor)
        {
            saldo -= valor;
            ++cont_Saque;
        }
        public override string ToString()
        {
            return "O titular " + this.titular + " possui as seguintes informações listadas abaixo";
        }
    }
}
