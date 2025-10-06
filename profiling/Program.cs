using System;
using System.Diagnostics;

Stopwatch timer = new Stopwatch();
int[] profilingNs = { 1, 10, 100, 1000, 10000, 1000000 };

Console.WriteLine("Starting profiling.... \n");

Console.WriteLine("Ejercicio1");
foreach (int i in profilingNs)
{
    timer.Start();
    Ejercicio1(i);
    timer.Stop();
    Console.WriteLine($"n = {i}");
    Console.WriteLine($"Ejercicio 1: {timer.Elapsed.TotalMilliseconds} ms");
}
Console.WriteLine();

Console.WriteLine("Ejercicio2");
foreach (int i in profilingNs)
{
    timer.Start();
    Ejercicio2(i);
    timer.Stop();
    Console.WriteLine($"n = {i}");
    Console.WriteLine($"Ejercicio 2: {timer.Elapsed.TotalMilliseconds} ms");
}
Console.WriteLine();

Console.WriteLine("Ejercicio3");
foreach (int i in profilingNs)
{
    timer.Start();
    Ejercicio3(i);
    timer.Stop();
    Console.WriteLine($"n = {i}");
    Console.WriteLine($"Ejercicio 3: {timer.Elapsed.TotalMilliseconds} ms");
}
Console.WriteLine();
Console.ReadLine();




void Ejercicio1(int n)
{
    int i, j, k = 0;
    long counter = 0;

    for (i = n / 2; i <= n; i++)
    {
        for (j = 1; j + n / 2 <= 2; j++)
        {
            for (k = 1; k <= n; k = k * 2)
            {
                counter++;
            }
        }
    }
}

void Ejercicio2(int n)
{
    if (n <= 1) return;
    int i, j;
    long counter = 0;
    for (i = 1; i <= n; i++)
    {
        for (j = 1; j <= n; j++)
        {
            //Console.WriteLine("Sequence");
            counter++;
            break;
        }
    }
}

void Ejercicio3(int n)
{
    int i, j;
    long counter = 0;
    for (i = 1; i < n / 3; i++)
    {
        for (j = 1; j <= n; j += 4)
        {
            counter++;
        }
    }
}
