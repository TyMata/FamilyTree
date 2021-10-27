using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Persona
    {
        private string nombre;
        private int edad;
        public int Edad{
            get
            {
                return this.edad;
            }}
        public Persona(string nomb, int ed)
        {
            this.nombre = nomb;
            this.edad = ed;
        }
        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
