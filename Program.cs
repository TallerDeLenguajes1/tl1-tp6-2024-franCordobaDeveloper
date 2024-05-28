// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Hello, World!");

int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);
*/

/*
    Ejercicio 1. Construir un programa que permita invertir un número. Verifique que el
    texto ingresado es de hecho un número y, en caso afirmativo, realice la inversión del
    número sólo si éste es mayor a 0.
*/


// public class Calculadora {
//     private double dato;

//     public void Sumar(double termino) {
//         dato += termino;
//     }

// public double Resultado( get => valor );
// }



/*
int num, numInvertido = 0;
bool control = false;

string? numString;

while(!control) 
{

    Console.WriteLine("Ingrese un numero para invertir: ");
    numString = Console.ReadLine();
    control = int.TryParse(numString, out num);

    if(!control) 
    {

        Console.WriteLine("El valor ingresado en incorrecto: " + numString);

    } else 
    {
        if (num > 0)
        {
            numInvertido = 0;
            while (num > 0)
            {
                numInvertido = (numInvertido * 10) + (num % 10);
                num /= 10;
            }
            Console.WriteLine("el numero invertido es: " + numInvertido);
            break;
        }
        else
        {
            Console.WriteLine("el numero ingresado es negativo o cero");
        }
    }


}
*/

/*
Para los ejercicios 2 y 3, cree dos branchs en su repositorio, CalculadoraV1 y
CalculadoraV2
Ejercicio 2. Ingrese al branch CalculadoraV1 y construya un programa que sea una
calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar,
Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y que luego
pida dos números y que devuelva el resultado de la operación seleccionada. Además
una vez que termine de realizar la operación le pregunte si desea realizar otro cálculo.
*/

// variables
int opc; 
int num1, num2, resultado;
string? numString;
bool continuar = true;

while(continuar)
{
    // Menu
    do
    {
        Console.WriteLine("\nElija una opción : \n");
        Console.WriteLine("1) Sumar");
        Console.WriteLine("2) Restar");
        Console.WriteLine("3) Multiplicar");
        Console.WriteLine("4) Dividir");
        Console.WriteLine("0) Salir");

        numString = Console.ReadLine();
    } while(!int.TryParse(numString, out opc) || opc < 0 || opc > 4);

    if(opc == 0) 
    {
        Console.WriteLine("\nElegiste la opción 0 para salir");
        continuar = false;
    } 
    else 
    {
        bool control1 = true, control2 = true;

        Console.WriteLine("Ingrese el primer número: ");
        numString = Console.ReadLine();
        control1 = int.TryParse(numString, out num1);

        Console.WriteLine("Ingrese el segundo número: ");
        numString = Console.ReadLine();
        control2 = int.TryParse(numString, out num2);

        if(control1 && control2)
        {
            switch(opc)
            {
                case 1:
                    Console.WriteLine("1) Sumar dos números");
                    resultado = num1 + num2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case 2:
                    Console.WriteLine("2) Restar dos números");
                    resultado = num1 - num2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case 3:
                    Console.WriteLine("3) Multiplicar dos números");
                    resultado = num1 * num2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case 4:
                    Console.WriteLine("4) Dividir dos números");
                    if(num2 == 0) 
                    {
                        Console.WriteLine("No se puede dividir entre 0");
                    } 
                    else 
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("Resultado: " + resultado);
                    }
                    break;
            }
        }
        Console.WriteLine("\n¿Desea continuar utilizando la calculadora? (s/n): ");
        string? respuesta = Console.ReadLine();
        if (respuesta != null && (respuesta != "s" || respuesta != "S"))
        {
            continuar = false;
            Console.WriteLine("Saliendo de calculadora");
        }
    }
}
