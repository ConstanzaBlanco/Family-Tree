using System;
using System.Collections.Generic;
using System.Linq;

namespace Library;

public class Buscador
{
    private int Resultado { get; set; }
    public int Sumar(Person person)
    {
        int Resultado = 0;
        List<Person> lista = new List<Person>();
        lista.Add(person);
        foreach (Person descendiente in lista)
        {
            if (descendiente.Children.Any())
            {
                foreach (Person child in descendiente.Children)
                {
                    lista.Add(child);
                }
            }
        }

        foreach (Person familiar in lista)
        {
            Resultado += familiar.Age;
            Console.WriteLine(Resultado);
        }

        return Resultado;
    }

    public int Sumar(Node node)
    {
        int Resultado = 0;
        List<Node> lista = new List<Node>();
        lista.Add(node);
        foreach (Node nodo in lista)
        {
            if (nodo.Children.Any())
            {
                foreach (Node child in node.Children)
                {
                    lista.Add(child);
                }
            }
        }

        foreach (Node nod in lista)
        {
            Resultado += nod.Number;
        }

        return Resultado;
    }

    public Buscador()
    {
        this.Resultado = 0;
    }
}