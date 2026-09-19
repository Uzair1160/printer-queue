namespace PrinterQueueApp;

public class Druckerwarteschlange
{
    Queue<string> queue = new Queue<string>();
    public void Auftrag(string dokument)
    {
        queue.Enqueue(dokument);
    }
    public string? Drucke()
    {
        throw new NotImplementedException();
    }
    public string? Naechster { get; }
    public int offen { get; }
}