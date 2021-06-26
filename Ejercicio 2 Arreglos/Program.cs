using System;

namespace Ejercicio_2_Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ingresar alguna cadena de caracacteres");
            Console.Write("Ingresa numero maximo de caracteres: ");
            Console.ForegroundColor = ConsoleColor.White; int n = int.Parse(Console.ReadLine()); char[] cadena = new char[n];//-- se crea el arreglo             
            for(int i = 0; i < n; i++)//-- guarda los caracteres 
            {
                Console.WriteLine("Escribe el caracter " + (i + 1) + ": "); cadena[i] = Convert.ToChar(Console.ReadLine());
            }
            Cadenas Ccadena = new Cadenas(cadena);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Indica lo que quieres que se realice: ");
            Console.WriteLine("a.) La cadena escrita al revés.");
            Console.WriteLine("b.) La cadena en mayúsculas.");
            Console.WriteLine("c.) La cadena anterior modificada según las siguientes reglas\n" +
                "A=4\n" +
                "I=1\n" +
                "S=5\n" +
                "B=8\n" +
                "E=3\n" +
                "T=7");
            Console.ForegroundColor = ConsoleColor.White;
            char ans = char.ToUpper(Convert.ToChar(Console.Read())); Console.Clear();
            switch (ans)//-- se verifica que opcion se escogio 
            {
                case 'A': Console.WriteLine(Ccadena.Reversa()); break;
                case 'B': Console.WriteLine(Ccadena.Mayusculas()); break;
                case 'C':
                    {
                        foreach (char c in Ccadena.Sustitucion())
                        {
                            Console.WriteLine(c);
                        }
                        break;
                    }
                default: Console.WriteLine("Error no se encuetra en la lista"); break;
            }
        }
    }
}





//INTERFACE
interface ICadenas 
{
    string Reversa(); string Mayusculas(); char[] Sustitucion();
}




// CLASE DERIVADA
class Cadenas: ICadenas 
// ATRIBUTOS 
{
    char[] charArr; string cadena;
    // CONSTRUCTOR      
    public Cadenas(char[] cadena) 
    {
        CharArr = cadena;
    }
    //PROPIEDADES    
    public char[] CharArr { get => charArr; set => charArr = value; }     
    public string Cadena { get => cadena; set => cadena = value; }     
    // METODOS 
    public string Mayusculas()//DEVULEVE LA CADENA EN MAYUSCULAS 
    {
        string ans = "";
        foreach (char c in CharArr)// RECORRE EL ARREGLO Y LO AGREGA A CADENA 
        {
            ans += char.ToUpper(c) + "\n";
        }
        return ans;
    }
    public string Reversa()
    {
        string ans = "";
        for (int i = CharArr.Length - 1; i != -1; i--)//RECORRE EL ARREGLO DE REVERSA Y LO GUARDA CONSECUTIVAMENTE 
        {
            ans += CharArr[i] + "\n";
        }
        return ans;
    }
    public char[] Sustitucion()
    {
        for (int i = 0; i < CharArr.Length; i++)//RECORRE EL ARREGLO 
        { 
            switch (CharArr[i])//EVALUA EL CARACTER PARA SUSTITUIR 
            {
                case 'A': CharArr[i] = '4'; break;
                case 'I': CharArr[i] = '1'; break;
                case 'S': CharArr[i] = '5'; break;
                case 'B': CharArr[i] = '8'; break;
                case 'E': CharArr[i] = '3'; break;
                case 'T': CharArr[i] = '7'; break;
            }
    }
    return CharArr;
} 
}  

