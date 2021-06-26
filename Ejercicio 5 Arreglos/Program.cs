using System;

namespace Ejercicio_5_Arreglos
{
 class Program
 {
  static void Main(string[] args)
  {
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Hola, somos un taller mecanico en el cual arreglaremos tu auto" +"¡Y lo dejaremos con las 3 B");
    Console.ForegroundColor = ConsoleColor.White;
    Taller taller = new Taller(7);// SE INSTANCIA CON 7 QUE ES LA MAX. CAPACIDAD DE AUTOS
    Console.WriteLine(taller.EspacioDisponible());
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Te mostramos los espacios disponibles"); 
    Console.WriteLine("Al ingresar 'S' el programa se cerrara"); 
        char ans; char salir = 'f'; 
            while (salir != 'S')
        {
           Console.ForegroundColor = ConsoleColor.Cyan;
           Console.WriteLine("¿Que es lo que desea hacer?");
           Console.WriteLine("A)Meter\nB)sacar\n"); Console.WriteLine("Seleccione opcion: ");
           ans = char.ToUpper(Convert.ToChar(Console.ReadLine()));
           Console.ForegroundColor = ConsoleColor.White;
           Console.Clear(); switch (ans)
           {
             case 'A':
             {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Ha seleccionado meter");
                Console.Write("Introduzca su placa: "); Console.ForegroundColor = ConsoleColor.White; string placa = Convert.ToString(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Introduzca su nombre: "); Console.ForegroundColor = ConsoleColor.White; string nombre = Convert.ToString(Console.ReadLine());
                if (taller.Meter(placa, nombre) == false)
                {
                  Console.WriteLine("Lo sentimos, tabla llena");
                  Console.ReadKey();
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Clear();
                Console.WriteLine("Se ha actualizado la tabla");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(taller.EspacioDisponible());
                Console.ReadKey(); break;
             }
             case 'B':
             {
               Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("Ha seleccionado sacar"); if (taller.Sacar() == false)
               {
                 Console.WriteLine("Lo sentimos, tabla vacia");
                 Console.ReadKey();
               }
               Console.WriteLine("Se ha actualizado la tabla"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(taller.EspacioDisponible());
               Console.ReadKey(); break;
             }
           }
           Console.Clear();
           Console.WriteLine("Para salir seleccione la letra S o para continuar seleccione cualquier otra tecla");
           salir = char.ToUpper(Convert.ToChar(Console.ReadLine()));
           Console.Clear();
            }
        }
    }
}


