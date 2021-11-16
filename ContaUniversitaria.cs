using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6
{
    public class ContaUniversitaria : Conta
    {
         private DateTime dataAneversario;
        private string publicodaconta = "Exclusiva para universitários com idade entre 16 e 28 anos";
        private string vantagens = "Não precisa comprovar renda. Disponível cartão de débito e de crédito";
        private string caracteristicas = "Conta individual com limite de cheque especial, movimentada por cartão,cheque, internet e celular";
        private string tipo = "Conta universitária";

         public ContaUniversitaria( DateTime d, string t) : base(t)
        {
            dataAneversario = d;
        }
        public override string Id
        {
            get {return this.Titular + "(CP)";}
        }
          public override string ToString()
        {
             return base.ToString() + " (CP)"+
            "Data de aniversario: " + dataAneversario +
            "Público da conta: " + publicodaconta +
             "\nTipo de conta: " + tipo +
            "\nVantagens: " + vantagens +
            "\nCaracterísticas: " + caracteristicas + 
            "\nEssa conta não tem taxa de juros" +
            "\nSaldo atual: " + Saldo + 
            "\nQuantidade de saque: " + base.saque +
            "\nQuantidade de depósito: " + base.deposito;
        }
    }
}