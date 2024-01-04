using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int conta, decimal saldoInicial)
        {
            NumeroConta = conta;
            Saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }
        private decimal Saldo;
        
        public void Sacar(decimal Valor){
            
            if (Valor > Saldo){
                Console.WriteLine("Saldo insuficiente");
            }
            else{
                Saldo -=Valor;
            }
        }
        public void ExibirSaldo(){
            Console.WriteLine($"Seu saldo é de {Saldo}");
        }
    }
}
   