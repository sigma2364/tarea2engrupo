using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Prosesos
{
    public class Terreno
    {
        #region Variables

        double area;

        #endregion

        #region Metodos

        public double calculaArea (double largo, double ancho)
        {
            return area = largo * ancho;
        }

        public string validarTerreno()
        {
            string validacion = "TERRENO NO APTO PARA CONSTRUCCION";

            if (area >= 100)
                validacion = "TERRENO APTO PARA CONSTRUCCION";

            return validacion;
        }

        public string validarTerreno(double largo, double ancho)
        {
            string validacion = "TERRENO NO APTO PARA CONSTRUCCION";

            if (area >= 200 && largo >= 20 || area >= 300 && ancho >=10)
                validacion = "TERRENO APTO PARA CONSTRUCCION";

            return validacion;
        }
        #endregion


    }
}
