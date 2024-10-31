using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library;

public class Person
{
    private int age;
    private string name;

    private List<Person> children = new List<Person>();

    public int Age {
        get
        {
            return this.age;
        }
    }

    public string Name
    {
        get
        {
            return this.name;
        }
    }

    public ReadOnlyCollection<Person> Children {
        get
        {
            return this.children.AsReadOnly();
        }
    }

    public Person(int age,string name)
    {
        this.age = age;
        this.name = name;
    }

    public void AddChildren(Person n)
    {
        this.children.Add(n);
    }

    public void AcceptBuscadorSuma(Buscador buscador)
    {
        buscador.Sumar(this);
    }

    public void AcceptBuscadorNombre(Buscador buscador)
    {
        buscador.NombreMasLargo(this);
    }
    
    public void AcceptBuscadorHijoMayorEdad(Buscador buscador)
    {
        buscador.AncestroMayorEdad(this);
    }
}