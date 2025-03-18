using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TP03.geometria
{
    internal class TestarFiguras
    {
        public static void Executar()
        {
            FigurasGeometricas.Circulo circulo = new FigurasGeometricas.Circulo(3.0);
            FigurasGeometricas.Esfera esfera = new FigurasGeometricas.Esfera(5.0);

            double areaCirculo = circulo.CalcularArea();
            double volumeEsfera = esfera.CalcularVolume();

            Console.WriteLine("Área do círculo com raio 3: " + areaCirculo);
            Console.WriteLine("Volume da esfera com raio 5: " + volumeEsfera);
        }
    }
}
