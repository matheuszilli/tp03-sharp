using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP03.geometria
{
    internal class FigurasGeometricas
    {
        public class Circulo
        {
            public double Raio { get; set; }

            public Circulo(double raio)
            {
                Raio = raio;
            }

            public double CalcularArea()
            {
                return Math.PI * (Raio * Raio);
            }
        }

        public class Esfera
        {
            public double Raio { get; set; }

            public Esfera(double raio)
            {
                Raio = raio;
            }

            public double CalcularVolume()
            {
                return (4.0 / 3.0) * Math.PI * (Raio * Raio * Raio);
            }
        }
    }
}
