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

        protected int ContentBuilder { get; }

        public abstract void Visit(Node nodo);
    }
}