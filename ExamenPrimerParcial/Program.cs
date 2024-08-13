
using System;

namespace ExamenPrimerParcial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int opcion;
            do
            {
                MenuPrincipal();
                opcion = Convert.ToInt16(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Ejercicio1();
                        break;
                    case 2:
                        Ejercicio2();
                        break;
                    case 3:
                        Ejercicio3();
                        break;
                    case 4:
                        Console.WriteLine("Gracias por realizar su examen..");
                        break;
                    default:
                        break;
                }
            } while (opcion != 4);
        }
        public static void MenuPrincipalVentas()
        {
            Console.WriteLine("================MENU================");
            Console.WriteLine("1. Numeros mayores o menores que 7");
            Console.WriteLine("2. Calcular promedio de ventas por dependiente");
            Console.WriteLine("3. Identificar vocales");
            Console.WriteLine("4. Salir");
        }
        public static void Ejercicio1()
        {
            int n1;
            int n2;
            int i = 0;
            int numero = 0;

            Console.Write("Identificar numeros mayores o menores entre 1 y 9");
            Console.WriteLine();

            Console.WriteLine("Ingrese un número");
            Console.WriteLine(numero);

            if (numero < 7)
            {
                i = i + 1;
                n1 = i;
                Console.WriteLine("Números menores 7: ");
                Console.WriteLine(n1);
            }
            else if (numero > 7) ;
            {
                i = i + 1;
                n2 = i;
                Console.WriteLine("Números mayores 7: ");
                Console.WriteLine(n2);

            }

        }

        public static void Ejercicio2()
        {
            double dependienteA = 0;
            double dependienteB = 0;
            double dependienteC = 0;
            int totalDependienteA = 0;
            int totalDependienteB = 0;
            int totalDependienteC = 0;
            double calcularPromedioVentas;

            while (true)
            {
                Console.Write("Introducir código del dependiente (A, B, o C) o 'F' para finalizar: ");
                string codigo = Console.ReadLine().ToUpper(); // Convertimos a mayúsculas para evitar errores de entrada

                if (codigo == "F")
                {
                    break;
                }
                Console.Write("Introducir el valor total de la factura: ");
                double totalFactura = Convert.ToDouble(Console.ReadLine());

                if (codigo == "A")
                {
                    totalFactura = CalcularPromedioVentas();
                    dependienteA += totalFactura;
                    totalDependienteA++;
                }
                else if (codigo == "B")
                {
                    totalFactura = CalcularPromedioVentas();
                    dependienteB += totalFactura;
                    totalDependienteB++;
                }
                else if (codigo == "C")
                {
                    totalFactura = CalcularPromedioVentas();
                    dependienteC += totalFactura;
                    totalDependienteC++;
                }
                else
                {
                    Console.WriteLine("Código de dependiente no válido.");
                }
            }

            Console.ReadKey();
        }

        public static double CalcularPromedioVentas()
        {
            double totalDependienteA = Convert.ToDouble(Console.ReadLine());
            double totalDependienteB = Convert.ToDouble(Console.ReadLine());
            double totalDependienteC = Convert.ToDouble(Console.ReadLine());
            double dependienteA = Convert.ToDouble(Console.ReadLine());
            double dependienteB = Convert.ToDouble(Console.ReadLine());
            double dependienteC = Convert.ToDouble(Console.ReadLine());

            //Calculo de promedio por dependiente
            double promedioA = totalDependienteA > 0 ? dependienteA / totalDependienteA : 0;
            double promedioB = totalDependienteB > 0 ? dependienteB / totalDependienteB : 0;
            double promedioC = totalDependienteC > 0 ? dependienteC / totalDependienteC : 0;

            // Se muestran los resultados
            Console.WriteLine("Promedio de venta de dependiente A: " + promedioA);
            Console.WriteLine("Promedio de venta de dependiente B: " + promedioB);
            Console.WriteLine("Promedio de venta de dependiente C: " + promedioC);

        }




        public static void Ejercicio3() {

        Console.WriteLine("Introducir una vocal:");
        Console.WriteLine();
        string vocal = Console.ReadLine().ToUpper();
        switch (vocal)
        {
            case 'A':
                Console.WriteLine("Se ha pulsado la vocal A");
                break;
            case 'E':
                Console.WriteLine("Se ha pulsado la vocal E");
                break;
            case 'I':
                Console.WriteLine("Se ha pulsado la vocal I");
                break;
            case 'O':
                Console.WriteLine("Se ha pulsado la vocal O");
                break;
            case 'U':
                Console.WriteLine("Se ha pulsado la vocal U");
                break;
            default:
                Console.WriteLine("No es Vocal");
                break;
        }
    }
}


}
