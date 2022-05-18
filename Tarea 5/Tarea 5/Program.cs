Console.Clear();

Console.WriteLine("Ingrese su nombre:");
string nombre;
nombre = Console.ReadLine();
Console.WriteLine("Hola " + nombre);

Console.Write("Desea continuar? (S/N)");
var texto = Console.ReadLine();

while (texto.ToUpper() == "S")
{
    Console.Clear();
    Console.WriteLine("Hola, ingrese su nombre:");

    nombre = Console.ReadLine();
    Console.WriteLine("Hola " + nombre);

    Console.WriteLine("Desea continuar? (S/N)");
    texto = Console.ReadLine();
}

if (texto.ToUpper() == "N")
{

    Console.WriteLine("Programa finalizado correctamente");

}

else
{
    Console.WriteLine("Opcion no valida");
}