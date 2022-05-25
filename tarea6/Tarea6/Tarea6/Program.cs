int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);
int intentos = 0;
int numeroIngresado;
do
{
    intentos++;
    Console.WriteLine("Ingrese un numero: ");
    numeroIngresado = int.Parse(Console.ReadLine());
    if (numeroIngresado > numeroSecreto)
    {
        Console.WriteLine("El nÃºmero ingresado es muy grande. Intenta de nuevo.");
    }
    else if (numeroIngresado < numeroSecreto)
    {
        Console.WriteLine("El nÃºmero ingresado es muy chico. Intenta de nuevo.");
    }
    else
    {
        Console.WriteLine($"Felicitaciones, has adivinado el nÃºmero secreto que era:  {numeroSecreto}");
        Console.WriteLine($"Lo has logrado en {intentos} intentos!!");
    }
} while (numeroSecreto != numeroIngresado);