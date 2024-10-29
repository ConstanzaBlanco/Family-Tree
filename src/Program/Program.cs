using System;
using System.Collections.Generic;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí

            Person p1 = new Person(80, "Jose");
            
            Person p2 = new Person(55, "Graciela");
            Person p3 = new Person(57, "Marcela");
            
            Person p4 = new Person(23, "Joaquin");
            Person p5 = new Person(22, "Lucas");
            Person p6 = new Person(30, "Sabrina");
            
            Person p7 = new Person(5, "Gennaro");
            
            p1.AddChildren(p2);
            p1.AddChildren(p3);
            
            p2.AddChildren(p4);
            p3.AddChildren(p5);
            p3.AddChildren(p6);
            
            p6.AddChildren(p7);

            Buscador b1 = new Buscador();
            p1.AcceptBuscadorSuma(b1);
            b1.Sumar(p1);
        }
    }
}
