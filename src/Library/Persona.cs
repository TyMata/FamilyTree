using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Persona
    {
        private string nombre;
        private int edad;
        public Persona(string nomb, int ed)
        {
            this.nombre = nomb;
            this.edad = ed;
        }        
    }
}
