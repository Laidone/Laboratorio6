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
            poupanca.Depositar(78);
            System.Console.WriteLine(poupanca.Id);
            ContaCorrente corrente = new ContaCorrente(new DateTime(2018, 11, 16), "Laidone");
            corrente.Depositar(1000);
            corrente.Sacar(300);
            corrente.Sacar(500);
            //System.Console.WriteLine(corrente.Id);
            ContaCorrenteEspecial corrente_Especial = new ContaCorrenteEspecial(new DateTime (2019, 1, 30), "João");
            corrente_Especial.Depositar(900);
            corrente_Especial.Sacar(150);
            corrente_Especial.Sacar(200);
            //System.Console.WriteLine(corrente_Especial.Id);
            ContaUniversitaria universitaria = new ContaUniversitaria(new DateTime(2020, 5, 16), "Carlos");
            universitaria.Depositar(600);
            universitaria.Sacar(55);
            universitaria.Sacar(376);
            List<Conta> colecao = new List<Conta>();
            colecao.Add(poupanca);
            colecao.Add(corrente);
            colecao.Add(corrente_Especial);
            colecao.Add(universitaria);
            System.Console.WriteLine("\n");
            System.Console.WriteLine(colecao[0]);
            System.Console.WriteLine(colecao[1]);
            System.Console.WriteLine(colecao[2]);
            System.Console.WriteLine(colecao[3]);
            /*
            Os métodos que podem ser chamados sobre os elementos da coleção são os métodos da classe conta, uma vez
            que a classe ContaPoupança, ContaUniversitaria, ContaCorrente e ContaCorrenteEspecial são do tipo abstrata. 
            */
        }
    }
}
