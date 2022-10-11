using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Prosesos
{
    public class PesoKilos
    {
        #region variables
        // declaración de variables



        private double cadakilo = 100;
        private double cada_kilometro = 500;
        private double adicional_valorpaquete = 0.1;


        #endregion

        #region propiedades

        //las propiedades sirven para reflejar en la siguiente capa


        //public double Pesokilos
        //{
        //    get { return pesokilos; }
        //    set { pesokilos = value; }
        //}

        //public double Valoraprox_paquete
        //{
        //    get { return valoraprox_paquete; }
        //    set { valoraprox_paquete = value; }
        //}

        //public double Cant_kilometros
        //{
        //    get { return cant_kilometros; }
        //    set { cant_kilometros = value; }
        //}

        //public int Cost_transporte
        //{
        //    get { return cost_transporte; }
        //    set { cost_transporte = value; }

        //}

        public double Cadakilo
        {
            get { return cadakilo; }
            set { cadakilo = value; }
        }

        public double Cada_kilometro
        {
            get { return cada_kilometro; }
            set { cada_kilometro = value; }
        }

        public double Adicional_valorpaquete
        {
            get { return adicional_valorpaquete; }
            set { adicional_valorpaquete = value; }
        }

        #endregion

        #region metodos

        public double Calculocostotransporte(double pesokilos, double valoraprox_paquete, double cant_kilometros)
        {
            double cost_transporte;
            cost_transporte = (pesokilos * 100) + (cant_kilometros * 500) + (valoraprox_paquete * 0.1);


            return cost_transporte;

        }


        #endregion

    }
}


