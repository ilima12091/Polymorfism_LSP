using System;

namespace LSPLibrary
{
    /*
        No cumple con el LSP porque cuando se le introduce un parámetro que no sea ni trello ni text el programa no funciona como se esperaria,
        nuestra solución a este problema seria crear una interfaz IAlert con la operación Send para poder crear tantos tipos de alertas como sean necesarios.
        A su vez sería necesaria la creación de una interfaz IPlatform para poder añadir más plataformas donde poder enviar las alertas por ejemplo "Whatsapp, messenger, slack, etc..."
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