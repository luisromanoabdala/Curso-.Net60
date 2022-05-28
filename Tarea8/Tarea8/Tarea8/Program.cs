Console.WriteLine("Ingrese la cantidad de filas: ");
int cantidadFilas = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de columnas: ");
int cantidadColumnas = int.Parse(Console.ReadLine());
int[,] matriz = new int[cantidadFilas, cantidadColumnas];
//Declaracion del vector
double[] promedios = new double[cantidadColumnas];
//Cargo  la matriz
for (int columna = 0; columna < cantidadColumnas; columna++)
{

    for (int fila = 0; fila < cantidadFilas; fila++)
    {
        Console.WriteLine($"Ingrese el numero de la Fila {fila + 1} y Columna {columna + 1}:");
        matriz[fila, columna] = int.Parse(Console.ReadLine());
    }
}
//Muestro datos de la matriz
Console.WriteLine("Valores de la Matriz:");
for (int columna = 0; columna < cantidadColumnas; columna++)
{

    for (int fila = 0; fila < cantidadFilas; fila++)
    {
        Console.WriteLine($"El numero de la fila {fila + 1} y columna {columna + 1} es: {matriz[fila, columna]}");

    }
}

//Calculo promedios
int suma = 0;
double prom;
for (int columna = 0; columna < cantidadColumnas; columna++)
{

    for (int fila = 0; fila < cantidadFilas; fila++)
    {
        suma += matriz[fila, columna];

    }
    prom = suma / cantidadFilas;
    //Asigno el promedio al vector
    promedios[columna] = prom;
}

//Muestro el vector
Console.WriteLine("Valores del Vector de promedios:");
for (int i = 0; i < cantidadColumnas; i++)
{
    Console.WriteLine($"Promedio {i + 1}: {promedios[i]}");
}