using System;
using System.Collections.Generic;
using System.Linq;

namespace Library;

public class Buscador
{
    private int Resultado { get; set; }
    
    // Este metodo lo que hace es recorrer la familia entera, a medida que recorre cada miembro, va sumando las edades.
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
        Console.WriteLine($"Desde {person.Name} hasta su ultimo ancestro, la suma de sus edades es {Resultado}");
        return Resultado;
    }

    // Funciona de la misma manera que el metodo sumar que recibe un Person, solo que este funciona con Node
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
        Console.WriteLine($"Desde el primer nodo dado hasta su ultimo ancestro, la suma de sus numeros es {Resultado}");
        return Resultado;
    }

    // Este metodo funciona de la misma forma que el metodo Suma, solo que a medida que va recorriendo los miembros de la familia
    // compara sus nombres con el nombre mas largo guardado anteriomente, guardando asi el nombre mas largo de toda la familia.
    public string NombreMasLargo(Person person)
    {
        int CantLetras = 0;
        string nombre = "";
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
        Console.WriteLine($"El nombre mas largo desde {person.Name} hasta su ultimo ancestro es: {nombre}");
        return nombre;
    }

    // Este metodofunciona de igual forma que el metodo NombreMasLargo, perocon la diferencia de que al recorrer a los membros de la familia va comparando
    // las edades con la edad mas grande hallada hasta el momento, y si es mayor que la edad anterior esta nueva edad reemplaza a la mayor edad anterior,
    // devolviendo asi la edad mas grande la de familia
    
    //En caso de que se quiera buscar el Ancestro mas grande entre los nodos, loque hay que hacer es usar este mismo metodo, pero que reciba como parametro un Node
    //(junto con algunos cambios menores en el metodo para que funcione con parametros de tipo Node)
    public int AncestroMayorEdad(Person person)
    {
        int Num = 0;
        string NombremayorEdad = "";
                
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
                    if (familiar.Age>=Num)
                    {
                        Num = familiar.Age;
                        NombremayorEdad = familiar.Name;
                    }
                }
                Console.WriteLine($"La persona de mayor edad en la familia de {person.Name} es: {NombremayorEdad} con {Num} años");
                return Num;
    }
}