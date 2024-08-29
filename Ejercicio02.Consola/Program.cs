using Ejercicio02.Entidades;

namespace Ejercicio02.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Verificar una CURP");
            Console.WriteLine("2. Generar una CURP");
            Console.Write("Seleccione una opción (1 o 2): ");
            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.Write("Ingrese la CURP a verificar: ");
                string curp = Console.ReadLine();
                bool esValido = ValidadorCURP.Validar(curp);
                Console.WriteLine(esValido ? "La CURP es válida." : "La CURP no es válida joder!!!");
            }
            else if (opcion == "2")
            {
                Console.Write("Ingrese su nombre completo: ");
                string nombreCompleto = Console.ReadLine();
                Console.Write("Ingrese su fecha de nacimiento (AAAA-MM-DD): ");
                DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());
                Console.Write("Ingrese su lugar de nacimiento: ");
                string lugarNacimiento = Console.ReadLine();
                Console.Write("Ingrese su sexo (M/F): ");
                char sexo = char.Parse(Console.ReadLine().ToUpper());

                string curp = ValidadorCURP.GenerarCurp(nombreCompleto, fechaNacimiento, lugarNacimiento, sexo);
                Console.WriteLine($"La CURP generada es: {curp}");
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }
    }
    }

