using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialRombo.Entidades
{
    public class Rombo
    {
        public int DiagonalMayor { get; set; }
        public int DiagonalMenor { get; set; }
        public Contorno Contorno { get; set; }

        public Rombo()
        {
            
        }
        public double Lado => Math.Sqrt(Math.Pow(DiagonalMayor / 2.0, 2) + Math.Pow(DiagonalMenor / 2.0, 2));


        public double CalcularArea()
        {
            return (DiagonalMayor * DiagonalMenor) / 2.0;
        }

        // Método para calcular el perímetro del rombo
        public double CalcularPerimetro()
        {
            return 4 * Lado;
        }

        public Rombo(int diagonalMayor, int diagonalMenor, Contorno contorno)
        {
            DiagonalMayor = diagonalMayor;
            DiagonalMenor = diagonalMenor;
            Contorno = contorno;
        }
    }
}
