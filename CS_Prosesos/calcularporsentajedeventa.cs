using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Prosesos
{
    public class calcularporsentajedeventa
    {

        public double mPorsentaje(double P_costo)
        {
 
            double P_venta = Convert.ToDouble( P_costo +(P_costo * 0.50));
            P_venta = Math.Round(P_venta, 2);

            return P_venta;
            

        }

        


    }
}
