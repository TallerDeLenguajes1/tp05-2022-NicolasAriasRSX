using System;

double num1, num2, resultado= 0;
int operacion;
Console.WriteLine("Bienvenido a la calculadora V2\n");
do
{
    Console.WriteLine("Seleccione que desea hacer\n1->Varias operaciones\n2->Calculadora V1\n3->Maximo entre 2 numeros");
    operacion= Convert.ToInt32(Console.ReadLine());
    switch(operacion)
    {
        case 1:
            operacionesVarias();
            break;
        case 2:
            calculadoraSimple();
            break;
        case 3:
            mayorMenor();
            break;
        default:
            Console.WriteLine("Opcion equivocada");
            break;
    }
    Console.WriteLine("Desea realizar otra operacion?");
    Console.WriteLine("\n1->Si\n2->No");
    operacion= Convert.ToInt32(Console.ReadLine());
} while (operacion == 1);

//Funciones
void calculadoraSimple()
{
    do
    {
        Console.WriteLine("Ingrese el primer numero: ");
        num1= double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero: ");
        num2= double.Parse(Console.ReadLine());
        Console.WriteLine("Seleccione la operacion:\n1->Suma\n2->Resta\n3->Producto\n4->Cocinete");
        operacion= Convert.ToInt32(Console.ReadLine());
        switch (operacion)
        {
            case 1:
                resultado= num1 + num2;
                break;
            case 2:
                resultado= num1 - num2;
                break;
            case 3:
                resultado= num1 * num2;
                break;
            case 4:
                if (num2 > 0)
                {
                    resultado= num1 / num2;
                }else{
                    Console.WriteLine("No esta definida la divicion en 0");
                    resultado= 0;
                }
                break;
            default:
                Console.WriteLine("Seleccione de nuevo la operacion");
                break;
        }
        Console.WriteLine("El resultado de la operacion es: " + resultado);
        Console.WriteLine("Desea realizar otra operacion en la calculadora?\n1->Si\n2->No");
        operacion= Convert.ToInt32(Console.ReadLine());
    } while (operacion == 1);
}
void operacionesVarias()
{
    Console.WriteLine("Ingrese un numero: ");
    num1= double.Parse(Console.ReadLine());
    Console.WriteLine("El valor absoluto es: " + Math.Abs(num1));
    Console.WriteLine("El cuadrado es: " + Math.Pow(num1,2));
    Console.WriteLine("La raiz cuadrada es: " + Math.Sqrt(num1));
    Console.WriteLine("El seno es: " + Math.Sin(num1));
    Console.WriteLine("El coseno es: " + Math.Cos(num1));
    Console.WriteLine("La parte entera es : " + Math.Truncate(num1));
}
void mayorMenor()
{
    Console.WriteLine("Ingrese el primer numero: ");
    num1= double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo numero: ");
    num2= double.Parse(Console.ReadLine());
    Console.WriteLine("El mayor es: " + Math.Max(num1,num2));
    Console.WriteLine("El menor es: " + Math.Min(num1,num2));
}