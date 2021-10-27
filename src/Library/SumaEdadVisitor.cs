using System;

namespace Library
{
    public class SumaEdadVisitor: Visitor
    {
        
        public override void Visit(Node nodo)
        {
            foreach (var hijo in nodo.Children)
            {
                if (hijo.Children != null)
                {
                    hijo.Accept(this);
                    hijo.Persona.Accept(this);
            
                }
            }
        }
        public override void Visit(Persona persona)
        {
            ContentBuilder += persona.Edad;
        }
    }
}