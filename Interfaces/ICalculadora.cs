using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOCSharp.Interfaces
{
    public interface ICalculadora
    {
        // Em interfaces não temos os acessores de public e private, pq se entende que ele já é publico
        int Somar (int numero1, int numero2);
        int Subtrair (int numero1, int numero2);
        int Multiplicar (int numero1, int numero2);
        int Dividir (int numero1, int numero2);
        
    }
}