using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Models
{
    public abstract class Conta
    {
        protected decimal Saldo;
        public abstract void Creditar(decimal Valor);
        public abstract void Remover(decimal Valor);
        public void ExibirSaldo(){
            Console.WriteLine($"Seu saldo é de: {Saldo}");
        }
    }
}