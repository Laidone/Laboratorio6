using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6
{
    public class ContaCorrenteEspecial : Conta
    {
        private DateTime dataAneversario;
        private string publicodaconta = "Pessoas físicas e jurídicas";
        private string vantagens = "Acesso a todos os investimentos, produtos e serviços";
        private string caracteristicas = "Conta com limite de cheque especial, movimentada por cartão,cheque, internet e celular";
        private string tipo = "Conta corrente especial";
         public ContaCorrenteEspecial( DateTime d, string t) : base(t)
        {
            dataAneversario = d;
        }
         public override string Id
        {
            get { return ToString() + " (CP)"+
            "Data de aniversario: " + dataAneversario +
            "Público da conta: " + publicodaconta +
             "\nTipo de conta: " + tipo +
            "\nVantagens: " + vantagens +
            "\nCaracterísticas: " + caracteristicas + 
            "\nEssa conta não tem taxa de juros" +
            "\nSaldo atual: " + Saldo + 
            "\nQuantidade de saque: " + base.saque +
            "\nQuantidade de depósito: " + base.deposito;}
        }
    }
}