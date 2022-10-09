using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Prosesos
{
    public class promediodenotas
    {

        public double mPromedioNotas(double nota1, double nota2, double nota3)
        {
            
            
            double promedio = Convert.ToDouble(nota1 + nota2 + nota3) / 3;
            promedio = Math.Round(promedio, 2);

            return promedio;
        }
        


    }
}
