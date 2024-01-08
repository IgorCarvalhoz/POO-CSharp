using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POOCSharp.Interfaces;

namespace POOCSharp.Models
{
    public class Calculadora : ICalculadora
    {
        //Para implementar a interface somos obrigados a implementar todos os atributos da interface
        public int Dividir(int numero1, int numero2)
        {
            return numero1 / numero2;
        }

        public int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        public int Somar (int numero1, int numero2){
            return numero1 + numero2;
        }

        public int Subtrair(int numero1, int numero2)
        {
            return numero1 - numero2;
        }
    }
}