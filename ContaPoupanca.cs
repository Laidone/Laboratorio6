using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6
{
    public class ContaPoupanca : Conta
    {
        private decimal taxaJuros;
        private DateTime dataAniversario;
        private string publicodaconta = "Pessoas físicas e jurídicas";
        private string vantagens = "Lucros sobre o que foi depositado";
        private string caracteristicas = "Uma conta para você movimentar seu dinheiro e ainda obter rendimentos";
        private string tipo = "Poupança";
        public ContaPoupanca(decimal j, DateTime d, string t) : base(t)
        {
            taxaJuros = j;
            dataAniversario = d;
        }
        public decimal Juros
        {
            get { return taxaJuros; }
            set { taxaJuros = value; }
        }
        public DateTime DataAniversario
        {
            get { return dataAniversario; }
        }
        public void AdicionarRendimento()
        {
            DateTime hoje = DateTime.Now;
            if (hoje.Day == dataAniversario.Day && hoje.Month == dataAniversario.Month)
            {
                decimal rendimento = this.Saldo * taxaJuros;
                this.Depositar(rendimento);
            }
        }
        public override string Id
        {
            get { return this.Titular + "(CP)" +
            "Data de aniversario: " + dataAniversario +
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