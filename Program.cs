using System;
using System.Collections.Generic;

namespace Laboratorio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaPoupanca poupanca = new ContaPoupanca (4, new DateTime(2016, 1, 1), "Maria");
            poupanca.Depositar(23);
            poupanca.Depositar(56);
            //System.Console.WriteLine(poupanca.Id);
            ContaCorrente corrente = new ContaCorrente(new DateTime(2018, 11, 16), "Laidone");
            //System.Console.WriteLine(corrente.Id);
            ContaCorrenteEspecial corrente_Especial = new ContaCorrenteEspecial(new DateTime (2019, 1, 30), "João");
            //System.Console.WriteLine(corrente_Especial.Id);
            ContaUniversitaria universitaria = new ContaUniversitaria(new DateTime(2020, 5, 16), "Carlos");
            List<Conta> colecao = new List<Conta>();
            colecao.Add(poupanca);
            colecao.Add(corrente);
            colecao.Add(corrente_Especial);
            colecao.Add(universitaria);
            System.Console.WriteLine(colecao[3]);
        }
    }
}
