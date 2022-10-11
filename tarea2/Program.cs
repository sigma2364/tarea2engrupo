using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Prosesos;


// un saludo cordial a todos

namespace tarea2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            #region Instancias
            //instanciamos las clases

            promediodenotas objnotas = new promediodenotas();

            calcularporsentajedeventa objporsentaje = new calcularporsentajedeventa();

            salario objSalario = new salario();

            Terreno objTerreno = new Terreno();

            #endregion

            #region variables
            //variables
            int opc = 0;
            double nota1, nota2, nota3, cod, P_costo, min, pagoHora, largo, ancho;
            string nombre, ced;

            //instancia ejercicio2
            PesoKilos eje2 = new PesoKilos();
            double pesokilos;
            double valor_aproxpaquete;
            double cant_kilometros;
            double calculotransporte;

            #endregion


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

                            Console.WriteLine("Digite el peso el kilos   ");
                            pesokilos = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Digite el valor aproximado del paquete   ");
                            valor_aproxpaquete = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(" Digite la cantidad de Kilómetros  ");
                            cant_kilometros = Convert.ToDouble(Console.ReadLine());




                            calculotransporte = eje2.Calculocostotransporte(pesokilos, valor_aproxpaquete, cant_kilometros);
                            Console.WriteLine($"El costo del transporte es   {calculotransporte}");
                            Console.ReadKey();

                            break;
                        case 3:

                            Console.WriteLine("Ingrese le nombre y apellidos del colaborador");
                            nombre = Console.ReadLine();                            
                            Console.WriteLine("Digite la cedula");
                            ced = Console.ReadLine();
                            Console.WriteLine("Ingrese el tiempo laborado, en minutos");
                            min = double.Parse(Console.ReadLine());
                            Console.WriteLine("Digite el monto por hora a pagar");
                            pagoHora =double.Parse(Console.ReadLine());

                            Console.WriteLine("Nombre: " + nombre + "\nCédula: " + ced);
                            Console.WriteLine("Salario Bruto: " + objSalario.salarioBruto(min,pagoHora));
                            Console.WriteLine("Seguro Social 9%: " + objSalario.totalDeucciones());
                            Console.WriteLine("Salario Neto a pagar: " + objSalario.salarioNeto());
                            Console.WriteLine("\n*********************************************************" +
                                              "\n*Muchas gracias !! Digite cualquier tecla para continuar*" +
                                              "\n*********************************************************");
                            Console.ReadKey();
                            break;
                        case 4:

                            Console.WriteLine("Ingrese el valor del largo del terreno en metros");
                            largo = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el valor del ancho del terreno en metros");
                            ancho = Double.Parse(Console.ReadLine());
                            Console.WriteLine("El area de su terreno es: " + objTerreno.calculaArea(largo, ancho) + " m2");
                            Console.WriteLine(objTerreno.validarTerreno());
                            Console.WriteLine("\n*********************************************************" +
                                              "\n*Muchas gracias !! Digite cualquier tecla para continuar*" +
                                              "\n*********************************************************");
                            Console.ReadKey();

                            break;
                        case 5:

                            Console.WriteLine("Ingrese el valor del largo del terreno en metros");
                            largo = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el valor del ancho del terreno en metros");
                            ancho = Double.Parse(Console.ReadLine());
                            Console.WriteLine("El area de su terreno es: " + objTerreno.calculaArea(largo, ancho) + " m2");
                            Console.WriteLine(objTerreno.validarTerreno(largo, ancho));
                            Console.WriteLine("\n*********************************************************" +
                                              "\n*Muchas gracias !! Digite cualquier tecla para continuar*" +
                                              "\n*********************************************************");
                            Console.ReadKey();


                            break;
                        case 6:

                            Console.Write("Ingrese la primera nota:");
                            nota1 = double.Parse(Console.ReadLine());
                            Console.Write("Ingrese la Segunda nota:");
                            nota2 = double.Parse(Console.ReadLine());
                            Console.Write("Ingrese la Tercer nota:");
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

                            Console.Write("Ingrese el codigo del articulo:");
                            cod = double.Parse(Console.ReadLine());
                            Console.Write("Ingrese el precio del articulo:");
                            P_costo = double.Parse(Console.ReadLine());


                            double P_venta = objporsentaje.mPorsentaje(P_costo);

                            if (P_costo < 60)
                            {
                                Console.Write("Su precio de costo es:  " + P_costo + "\nSu precio de venta final es:  " + P_venta + "\nel codigo del producto es es: " + cod + " La ganacia es del 50% ");
                            }
                            if (P_costo >= 60 == P_costo <= 150)
                            {
                                Console.Write("Su precio de costo es:  " + P_costo + "\nSu precio de venta final es:  " + P_venta + "\nel codigo del producto es es: " + cod + " La ganacia es del 35% ");
                            }
                            if (P_costo >= 151)
                            {
                                Console.Write("Su precio de costo es:  " + P_costo + "\nSu precio de venta final es:  " + P_venta + "\nel codigo del producto es es: " + cod + " La ganacia es del 25% ");
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
