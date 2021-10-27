using System;

namespace Library
{
    public abstract class Visitor
    {
        public int Content
        {
            get
            {
                return this.ContentBuilder;
            }
        }

        protected int ContentBuilder { get; set ; }

        public abstract void Visit(Node nodo);
        public abstract void Visit(Persona person);
    }
}