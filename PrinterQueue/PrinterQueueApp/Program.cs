namespace PrinterQueueApp;

class Program
{
    static void Main(string[] args)
    {
        Druckerwarteschlange drucker = new Druckerwarteschlange();
        foreach (string zeile in File.ReadAllLines("Input.txt"))
        {
            string z = zeile.Trim();
            if (z == "" || z.StartsWith("#"))
                continue;
            string[] teile = z.Split(';');
            string befehl =  teile[0].Trim().ToUpper();
            switch (befehl)
            {
                case "AUFTRAG":
                    if (teile.Length == 2 && teile[1].Trim() != "")
                        drucker.Auftrag(teile[1].Trim());
                    break;
                case "DRUCKE":
                    string? gedruckt = drucker.Drucke();
                    if (gedruckt != null)
                        Console.WriteLine($"Gedruckt: {gedruckt}");
                    else
                        Console.WriteLine("Gedruckt: Warteschlange leer");
                    break;
                case "NAECHSTER":
                    string? naechster = drucker.Naechster;
                    if (naechster != null)
                        Console.WriteLine($"Nächster: {naechster}");
                    else
                        Console.WriteLine("Nächster: keine");
                    break;
                case "OFFEN":
                    Console.WriteLine($"Offen: {drucker.Offen}");
                    break;
            }
        }
    }
}
