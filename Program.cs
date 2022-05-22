string cadena, cadena2, nuevaCadena, operacion;
double num1, num2, resultado; 
int ope=0;
Console.WriteLine("-------------------\nIngrese una cadena");
cadena= Console.ReadLine();

//Longitud de la cadena, usamos -> cadena.Length;
Console.WriteLine("-------------------\nLa longitud de la cadena es de: {0}", cadena.Length);
//Concatenar 2 cadenas, usamos -> string.Concat(cadena1, cadena2, cadena3, ...);
Console.WriteLine("-------------------\nIngrese una nueva cadena");
cadena2= Console.ReadLine();
nuevaCadena= string.Concat(cadena, " ", cadena2);
Console.WriteLine(nuevaCadena);
//Extraer una subcadena, usamos -> cadena.Substring(1,5); ()Rango.
Console.WriteLine("-------------------\nUna sub cadena");
Console.WriteLine("Subcadena: {0}.", nuevaCadena.Substring(1,5));
//recorrer una cadena con foreach
Console.WriteLine("------------------\nRecorrer una cadena con foreach:");
foreach (var caracter in nuevaCadena)
{
    Console.WriteLine(caracter + " ");
}
//Buscar una palabra, usamos -> cadena.contains devuelve true si esta false si no esta.
string buscar;
Console.WriteLine("-------------------\nIngrese la palabra a buscar");
buscar= Console.ReadLine();
if(cadena.Contains(buscar)){
    Console.WriteLine("Palabra encontrada");
}
else
{
    Console.WriteLine("No se encontro la palabra");
}
//cadena a mayuscula y minuscula
Console.WriteLine("--------------\nCadenas en mayuscula y minuscula.");
Console.WriteLine("Cadena a mayuscula:\n" + nuevaCadena.ToUpper());
Console.WriteLine("Cadena a minuscula:\n" + nuevaCadena.ToLower());
//Reemplazar una caracter por otro, usamos -> cadena.remplace("caraacter que sale","Caracter que entra")
Console.WriteLine("------------------\nIngrese el caracter que quiere insertar por el espacio");
string letra= Console.ReadLine();
nuevaCadena= nuevaCadena.Replace(" ", letra);
Console.WriteLine("Nueva cadena\n" + nuevaCadena);
//Calculadora nueva
Console.WriteLine("-----------------------------------------------\nOtra calculadora.\nIngrese la operacion, ej 543+231.");
operacion= Console.ReadLine();
if(operacion.Contains("+")){
    ope= 1;
}
if(operacion.Contains("-")){
    ope= 2;
}
if (operacion.Contains("*"))
{
    ope= 3;
}
if(operacion.Contains("/")){
    ope= 4;
}
string[] numeros = operacion.Split('+','-','*','/');
num1= Convert.ToDouble(numeros[0]);
num2= Convert.ToDouble(numeros[1]);
switch(ope)
{
    case 1:
        resultado= num1 + num2;
        Console.WriteLine("La suma de {0} y de {1} es igual a: {2}\n", num1, num2, resultado);
        break;
    case 2:
        resultado= num1 - num2;
        Console.WriteLine("La resta de {0} y de {1} es igual a: {2}\n", num1, num2, resultado);
        break;
    case 3:
        resultado= num1 * num2;
        Console.WriteLine("El producto entre {0} y {1} es igual a: {2}\n", num1, num2, resultado);
        break;
    case 4:
        if(num2 > 0){
            resultado= num1 / num2;
             Console.WriteLine("El cociente entre {0} y {1} es igual a: {2}\n", num1, num2, resultado);
        }else{
            Console.WriteLine("No es posible realizar esta operacion. No esta definida la divicion en 0");
        }
        break;
    default:
        Console.WriteLine("No selecciono carrectamente. Que le pasa.");
        break;
}
Console.WriteLine("---------------------------------\nFin del programa\n---------------------------------");