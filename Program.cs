//Programa para invertir un numero
int numero;
int result;
Console.WriteLine("Ingrese el numero para invertie; debe se ser mayor que 0");
numero= Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(numero);

if (numero > 0)
{
    result= InvertirNumero(numero);
    Console.WriteLine("El numero invertido es: " + result);
}else{
    Console.WriteLine("No es posible invertir el numero");
}

int InvertirNumero(int numero){
    int resultado= 0;
    while (numero > 0)
    {
        resultado= resultado * 10 + numero % 10;
        numero /= 10;
    }
    return resultado;
}