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
        for (int i = 0; i < lista.Count; i++) //Busca de manera anidadada el decendiete de la primer persona, el decendiente del decendiente y así anidadamente
        {
            Person descendiente = lista[i];
            if (descendiente.Children.Any())
            {
                lista.AddRange(descendiente.Children);
            }
        }

        foreach (Person familiar in lista) //Suma las edades de cada fimiliar contenidos en la lista
        {
            Resultado += familiar.Age;
        }
        Console.WriteLine($"Desde {person.Name} hasta su ultimo decendiente, la suma de sus edades es {Resultado}");
        return Resultado;
    }

    public int Sumar(Node node)
    {
        int Resultado = 0;
        List<Node> lista = new List<Node>();
        lista.Add(node);
        for (int i = 0; i < lista.Count; i++) //Busca de manera anidadada el decendiete del primer nodo, el decendiente del decendiente y así anidadamente
        {
            Node descendiente = lista[i];
            if (descendiente.Children.Any())
            {
                lista.AddRange(descendiente.Children);
            }
        }

        foreach (Node nod in lista)
        {
            Resultado += nod.Number; //Suma los numeros de cada nodo contenidos en la lista
        }
        Console.WriteLine($"Desde el primer nodo dado hasta su ultimo decendiente, la suma de sus numeros es {Resultado}");
        return Resultado;
    }

    public string NombreMasLargo(Person person)
    {
        int CantLetras = 0;
        string nombre = "";
        int nombres = 0;
        List<Person> lista = new List<Person>();
        lista.Add(person);
        for (int i = 0; i < lista.Count; i++) //Busca de manera anidadada el decendiete de la primer persona, el decendiente del decendiente y así anidadamente
        {
            Person descendiente = lista[i];
            if (descendiente.Children.Any())
            {
                lista.AddRange(descendiente.Children);
            }
        }

        foreach (Person familiar in lista) //Suma las edades de cada fimiliar contenidos en la lista
        {
            if (familiar.Name.Length>=CantLetras)
            {
                nombre = familiar.Name;
                CantLetras = familiar.Name.Length;
            }
        }
        Console.WriteLine("El nombre mas largo es: "+ nombre);
        return nombre;
    }
}