using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Models
{
    public class Aluno : Pessoa 
    {
        public double Nota { get; set; }

        public override void Apresentar()
        {
           Console.WriteLine($"Olá, sou o aluno {Nome} e minha nota atual é {Nota}");
        }
    }
}