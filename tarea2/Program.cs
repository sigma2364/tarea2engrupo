using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Prosesos;



namespace tarea2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //instanciamos las clases

            promediodenotas objnotas = new promediodenotas();
            
            calcularporsentajedeventa objporsentaje = new calcularporsentajedeventa();
           


            //variables
            int opc = 0;
            double  nota1, nota2, nota3, cod,  P_costo;



            while (opc != 8) //Menu de opciones
            {
                try
                {
                    Console.WriteLine("\n******Bienvenidos******\n " +
                        "Digite lo que desea hacer: " +
                    "\n1. Matricula de estudiantes" +
                    "\n2. Calculo de kilos por kilometros recorridos" +
                    "\n3. Calculo de salario neto" +
                    "\n4. Calcule el area total de un terreno" +
                    "\n5. Terreno para construir" +
                    "\n6. Calcule el promedio de notas" +
                    "\n7. Calculo de ventas" +
                    "\n8. Salir de este menu\n" +
                    "");
                    opc = int.Parse(Console.ReadLine());

                    switch (opc)
                    {
                        case 1:



                            break;
                        case 2:



                            break;
                        case 3:



                            break;
                        case 4:

                            break;
                        case 5:

                           

                            break;
                        case 6:

                            Console.Write("Ingrese la primera nota:");
                            nota1 = double.Parse(Console.ReadLine());
                            Console.Write("Ingrese la Segunda nota:");
                            nota2 = double.Parse(Console.ReadLine());
                            Console.Write("Ingrese la Treser nota:");
                            nota3 = double.Parse(Console.ReadLine());



                            double promedio = objnotas.mPromedioNotas(nota1, nota2, nota3);
                            
                                if (promedio >= 70 == nota3 >= 80 == promedio >= 60 == nota1 >=90 == nota2 >= 90 == nota3 >= 90) 

                                {
                                    Console.Write("Su Promedio final es:" + promedio + "Usted Aprobo ");
                                }
                                else
                                {
                                    Console.Write("Su Promedio final es:" + promedio + "Usted reprobo ");
                                }

                                Console.ReadKey();
                            

                            break;
                        case 7:

                            Console.Write("Ingrese El codigo del articulo:");
                            cod = double.Parse(Console.ReadLine());
                            Console.Write("Ingrese El precio del articulo:");
                            P_costo = double.Parse(Console.ReadLine());


                            double P_venta = objporsentaje.mPorsentaje(P_costo);

                            if (P_costo < 60)
                            {
                                Console.Write("Su Precio de costo es:  " + P_costo + "\nSu Precio de venta final es:  " + P_venta + "\nel codigo del producto es es: " + cod + " La ganacia es del 50% ");
                            }
                            if (P_costo >= 60 == P_costo <= 150)
                            {
                                Console.Write("Su Precio de costo es:  " + P_costo + "\nSu Precio de venta final es:  " + P_venta + "\nel codigo del producto es es: " + cod + " La ganacia es del 35% ");
                            }
                            if (P_costo >= 151)
                            {
                                Console.Write("Su Precio de costo es:  " + P_costo + "\nSu Precio de venta final es:  " + P_venta + "\nel codigo del producto es es: " + cod + " La ganacia es del 25% ");
                            }

                            Console.ReadKey();



                            break;
                        case 8:
                            break;
                        default:
                            Console.WriteLine("Opcion invalida");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Debe digitar un numero del Menu");

                }

            }

            Console.WriteLine("\n" +
                    "*****************************************************\n" +
                    "*Muchas gracias !! Digite cualquier tecla para salir*" +
                  "\n*****************************************************");
            Console.ReadKey();

        }
    }

}
