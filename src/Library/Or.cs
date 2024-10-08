﻿using Library.obj;

namespace Library;

public class Or : ILogicGate
{
    public string Name { get; }
    public List<Entrada> Entradas { get; }


    public Or(string name)
    {
        Name = name;
        Entradas = new List<Entrada>();
    }
    public void AgregarEntrada(string name, int valor)
    {
        if (ExistEn(name) != -1)
        {
            Entradas[ExistEn(name)].Valor = valor;
        }
        else
        {
            Entrada newEntrada = new Entrada(name, valor);
            Entradas.Add(newEntrada);
        }
    }
    private int ExistEn(string name)
    {
        int index = -1;
        int aux = 0;
        foreach (var entrada in Entradas)
        {
            if (entrada.Name == name)
            {
                index = aux;
            }
            aux++;
        }

        return index;
    }

    public int Calculate()
    {
        int prod = 0;
        foreach (var entrada in Entradas)
        {
            prod += entrada.Valor;
        }

        if (prod > 0)
        {
            prod = 1;
        }
        return prod;
    }
}
