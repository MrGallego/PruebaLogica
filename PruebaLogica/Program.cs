// See https://aka.ms/new-console-template for more information
using PruebaLogica;


Console.WriteLine("Hello, World!");

Console.WriteLine("Ejericio 1. Ingrese un numero: ");
int numero = Convert.ToInt32(Console.ReadLine());
int resultado= EjercicioUno.SumaMultiplos(numero);

Console.WriteLine(resultado);

Console.WriteLine("Ejercicio 2. Ingrese un texto con este ejemplo: Bienvenido a_Treda-solutions."); 
string texto = Console.ReadLine();

string resultadoDos = EjercicioDos.CamelCase(texto);

Console.WriteLine(resultadoDos);


Console.WriteLine("Ejercicio 3. Ingrese un texto donde algunas palabras superen las 5 letras: ");

string frase = Console.ReadLine();

string resultadoTres = EjercicioTres.ReverseLongWords(frase);

Console.WriteLine(resultadoTres);


Console.ReadKey();
