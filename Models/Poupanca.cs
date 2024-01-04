using OrientacaoObjetos.Models;

namespace POOCSharp.Models
{
    public class Poupanca : Conta {
        public override void Creditar(decimal Valor){
            Saldo += Valor;
        }
        public override void Remover(decimal Valor)
        {
            Saldo -= Valor;
        }
    }
}