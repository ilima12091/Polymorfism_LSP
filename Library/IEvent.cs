namespace LSPLibrary
{
    interface IEvent
    {
        public string EventName { get; set; }
        public string EventType { get; set; }
        
        public void Notify()
        {
          
        }
    }
}