namespace LSPLibrary
{
    /*
        No cumple con LSP porque no lo aplica ya que no hay un tipo genérico del cual herede.
        No cumple con polymorfism porque no hay forma de crear otro tipo de alerta.
    */
    public class Event
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