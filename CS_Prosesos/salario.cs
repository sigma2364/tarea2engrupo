using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Prosesos
{
    public class salario
    {

        #region Variables
        double horas, salBruto, deducciones;
        #endregion

        #region Metodos

        public double salarioBruto(double tiempo, double pagoHora)
        {
            horas = tiempo / 60;
            Console.WriteLine(horas);
            return salBruto = horas * pagoHora;
        }
        public double totalDeucciones()
        {            
            return salBruto * 0.09;
        }

        public double salarioNeto()
        {
            deducciones = totalDeucciones();
            return salBruto - deducciones;
        }
        #endregion
    }
}
