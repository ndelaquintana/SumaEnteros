using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        var sumaEnteros = new SumaEnteros();
        Console.WriteLine(sumaEnteros.Sume(1, 2, 3));

        var listaEnteros = new List<int> { 1, 2, 3, 4 };
        Console.WriteLine(sumaEnteros.Sume(listaEnteros));
    }
}

class SumaEnteros
{
    public int Sume(params int[] enteros)
    {
        if (enteros.Length == 0)
            throw new ArgumentException();

        return enteros.Sum();
    }
    public int Sume(List<int> enteros)
    {
        return Sume(enteros.ToArray());
    }
}