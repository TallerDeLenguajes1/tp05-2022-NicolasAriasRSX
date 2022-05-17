double num1, num2, resultado= 0;
int operacion;
Console.WriteLine("Bienvenido a la calculadora V1\n");
do
{
    Console.WriteLine("Ingrese el preimer numero: ");
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
                resultado= 000000000;
            }
            break;
        default:
            Console.WriteLine("Seleccione de nuevo la operacion");
            break;
    }
    Console.WriteLine("El resultado de la operacion es: " + resultado);
    Console.WriteLine("Desea realizar otra operacion?\n1->Si\n2->No");
    operacion= Convert.ToInt32(Console.ReadLine());
} while (operacion == 1);