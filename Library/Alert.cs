using System;

namespace LSPLibrary
{
    /*
        No cumple con el LSP porque se debería crear una interfaz IAlert con la operación Send para poder crear más de un tipo de alerta.
    */
    public class Alert
    {
        public void Send(string type, string text)
        {
            if (type == "trello")
            {
                new TrelloCardCreator().CreateCard(text);
            }
            else if (type == "text") 
            {
                Console.WriteLine(text);
            }
        }
    }
}