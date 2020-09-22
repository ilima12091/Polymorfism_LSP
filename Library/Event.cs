namespace LSPLibrary
{
    /*
        No cumple con LSP porque si quiero crear un evento nuevo por ejemplo "critical" el programa no ingresaria ese parámetro, 
        la solución sería crear una interfaz IEvent para poder crear nuevos eventos.
        No cumple con polymorfism porque no hay forma de crear otro tipo de evento que no sea "severe".
    */
    public class Event: IEvent
    {
        public string EventName { get; set; }
        public string EventType { get; set; }

        public void Notify()
        {
            new Alert().Send("text", this.EventName);

            if (this.EventType == "severe")
            {
                new Alert().Send("trello", this.EventName);
            }
        }
    }
}