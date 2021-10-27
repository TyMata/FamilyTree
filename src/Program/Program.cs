using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Library; 

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(new Persona("Elbio", 80));
            Node n2 = new Node(new Persona("Maria", 62));
            Node n3 = new Node(new Persona("Jose", 59));
            Node n4 = new Node(new Persona("Tomas", 40));
            Node n5 = new Node(new Persona("Lucas", 39));
            Node n6 = new Node(new Persona("Martina", 41));
            Node n7 = new Node(new Persona("Josefina", 26));

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí
            SumaEdadVisitor v = new SumaEdadVisitor();
            n1.Accept(v);
            Console.WriteLine(v.Content);
        }
    }
}
