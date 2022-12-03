using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Prosesos
{
    public class Matricula
    {
        #region variables
        // declaración de variables

        private string cedula;
        private string nombre;
        private string apellido;
        private int cant_materiaspracticas = 0;
        private double montototal;
        private int cant_materiasteoricas = 0;
        private double costomatri = 5000;
        private double costo_materiasteorica;
        private double costo_materiaspractica;


        #endregion
        // hola compañeros un gusto saludarlos
               //saludos 12/2/2022 Herbert 
               //saludos Santiago
               //Hola



            //Hola2
            //Hola 3
            //hola 4
            //hola 5




        #region propiedades   
       
        public string _cedula
        {
            get { return cedula; }
            set { cedula = value; }



        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }

        }

        public int Cant_materiaspracticas
        {
            get { return Cant_materiaspracticas; }
            set { Cant_materiaspracticas = value; }
        }

        public double Montototal
        {
            get { return montototal; }
            set { montototal = value; }

        }

        public double Cant_materiasteoricas
        {
            get { return Cant_materiasteoricas; }
            set { Cant_materiasteoricas = value; }

        }


        public double _Costomatri
        {
            get { return costomatri; }
            set { costomatri = value; }
        }

      


        #endregion

        #region metodos

        public void CalculoMateriasTeoricas(int cantmateriasTeoricas)
        {
            costo_materiasteorica = cantmateriasTeoricas * 1000;
        }

        public void CalculoMateirasPracticas(int cantmateeriasPracticas)
        {
            costo_materiaspractica = cantmateeriasPracticas * 2000;
        }

        public double CalculoTotal()
        {
            double _montototal = 0;
            _montototal = costo_materiaspractica + costo_materiasteorica + costomatri;
            return _montototal;
        }

        #endregion
    }

}








