using System;

namespace Ejercicico_1_arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            // el siguiente arrego sirve para el almacenamiento de los dtso
            int[] datos = new int[10];        
            //acontinuacion se instancea el objeto
            Numeros numeros = new Numeros(datos); 
            // aqui se guardn los datos en el objeto
            for (int i = 0; i < datos.Length; i++)
            {
                Console.WriteLine("Programa de ayuda multiple con 10  numeros -\n"); 
                Console.Write($"Escribir numero{(i + 1)}: "); datos[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            Console.Clear();
            Console.WriteLine("Programa de ayuda multiple con 10  numeros -\n"); 
            Console.WriteLine("Que opiciones son las que ocupas?: ");
            Console.WriteLine("A) Sumatoria de los 10 elementos.        B)Promedio de los elementos leídos.");
            Console.WriteLine("C)Número más grande de los números leídos. D)Número más pequeño de los números leídos");
            char ans = char.ToUpper(Convert.ToChar(Console.ReadLine())); switch (ans)
            {
                case 'A': Console.WriteLine(numeros.Suma()); break;
                case 'B': Console.WriteLine(numeros.Promedio()); break;
                case 'C':
                    {
                        int[] Ians = numeros.Ordenar(); Console.WriteLine(Ians[0]); break;
                    }
                case 'D':
                    {
                        int[] Ians = numeros.Ordenar(); Console.WriteLine(Ians[9]); break;
                    }
                default: Console.WriteLine("No la opcion seleccionada"); break;
            }
        }
    }
}  
// esta es la clase derivada
class Numeros: IDatos 
{
    private double ans;
//estsos son los atributos    
private int[] datos; 
// este es el construcotor
public Numeros(int[] datos) 
{
    Datos = datos;
}
//acontinuacio insertamos los metodos     
public double Suma() 
{
    for (int i = 0; i < Datos.Length; i++)
    {
        this.ans += Datos[i];
    }
    return ans;
}
public double Promedio()
{
    this.ans = this.Suma() / Datos.Length; return ans;
}
public int[] Ordenar()
{
    Array.Reverse(Datos); return Datos;
} 
// en esta parte ponemos las propiedaqdes 
public int[] Datos { get => datos; set => datos = value; } 
} 
//aqui se realiza la interfas 
interface IDatos 
{
    double Suma(); double Promedio(); int[] Ordenar();
} 

