int suma = 0;
int max=0,  min= 0;
double promedio = 0;
int[] numeros = new int[10];

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Ingrese el numero {i+1} ");
    numeros[i] = int.Parse(Console.ReadLine());
    if (i == 0)
    {
        max = numeros[i];
        min = numeros[i];
    }
    else {
        if (numeros[i] > max)
        {
            max = numeros[i];
        }
        if(numeros[i] < min)
        {
            min = numeros[i];
        }
     }
    suma += numeros[i];
    
}

promedio = suma / 10;
Console.WriteLine("Los datos son: ");
for(int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"El numero {i+1} es : {numeros[i]} ");

}

Console.WriteLine($" La suma de los numeros es : {suma}");
Console.WriteLine($" El promedio de los numeros es : {promedio}");
Console.WriteLine($" El maximo  de los numeros es : {max}");
Console.WriteLine($" El minimo de los numeros es : {min}");



