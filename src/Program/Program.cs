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
            Buscador buscadornodos = new Buscador();
            n1.AcceptBuscadorSuma(buscadornodos);

            // visitar el árbol aquí

            Person p1 = new Person(80, "Jose");
            Person p2 = new Person(85, "Maria");
            
            Person p3 = new Person(55, "Graciela");
            Person p4 = new Person(57, "Marcela");
            Person p5 = new Person(60, "Joaquin");
            
            Person p6 = new Person(33, "Lucas");
            Person p7 = new Person(30, "Sabrina");
            
            Person p8 = new Person(14, "Agustin");
            
            //El metodo AddChildren para nosotros lo que hace es agregar al padre o madre de la persona a la que indica, por lo que nuestro arbol se veria algo asi:
            //             Nieto
            //     Padre           Madre
            //Abuelo  Abuela  Abuelo  Abuela
            
            p8.AddChildren(p7);//Sabrina es Madre de Agustin
            p8.AddChildren(p6);//Lucas es padre de agustin
            
            p6.AddChildren(p3); //Graciela es madre de Lucas
            p7.AddChildren(p5); //Joaquin es padre de Sabrina
            p7.AddChildren(p4); //Marcela es madre de Sabrina
            
            p3.AddChildren(p2); //Maria es madre de Graciela
            p5.AddChildren(p1); //Jose es padre de Joaquin

            Buscador b1 = new Buscador();
            p8.AcceptBuscadorSuma(b1);
            p8.AcceptBuscadorHijoMayorEdad(b1);
            
        }
    }
}
