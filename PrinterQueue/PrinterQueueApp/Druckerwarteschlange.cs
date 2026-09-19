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

    public string? Naechster
    {
        get
        {
            if (queue.Count > 0)
            {
                return queue.Peek();
            }
            return null;
        }
    }
    public int offen { get; }
}