string cadena, cadena2, nuevaCadena;
Console.WriteLine("Ingrese una cadena");
cadena= Console.ReadLine();

//Longitud de la cadena, usamos -> cadena.Length;
Console.WriteLine("La longitud de la cadena es de: {0}", cadena.Length);
//Concatenar 2 cadenas, usamos -> string.Concat(cadena1, cadena2, cadena3, ...);
Console.WriteLine("Ingrese una nueva cadena");
cadena2= Console.ReadLine();
nuevaCadena= string.Concat(cadena, " ", cadena2);
Console.WriteLine(nuevaCadena);
//Extraer una subcadena, usamos -> cadena.Substring(1,5); ()Rango.
Console.WriteLine("Subcadena: {0}.", nuevaCadena.Substring(1,5));
//recorrer una cadena con foreach
Console.WriteLine("Recorrer una cadena con foreach:");
foreach (var caracter in nuevaCadena)
{
    Console.WriteLine(caracter + " ");
}
//Buscar una palabra, usamos -> cadena.contains devuelve true si esta false si no esta.
string buscar;
Console.WriteLine("Ingrese la palabra a buscar");
buscar= Console.ReadLine();
if(cadena.Contains(buscar)){
    Console.WriteLine("Palabra encontrada");
}
else
{
    Console.WriteLine("No se encontro la palabra");
}
//cadena a mayuscula y minuscula
Console.WriteLine("Cadena a mayuscula:\n" + nuevaCadena.ToUpper());
Console.WriteLine("Cadena a minuscula:\n" + nuevaCadena.ToLower());
//Reemplazar una caracter por otro, usamos -> cadena.remplace("caraacter que sale","Caracter que entra")
Console.WriteLine("Ingrese el caracter que quiere insertar por el espacio");
string letra= Console.ReadLine();
nuevaCadena= nuevaCadena.Replace(" ", letra);
Console.WriteLine("Nueva cadena\n" + nuevaCadena);