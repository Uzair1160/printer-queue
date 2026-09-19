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
        if (queue.Count > 0)
        {
            string name = queue.Dequeue();
            return name;
        }
        return null;
    }
    public string? Naechster { get; }
    public int offen { get; }
}