namespace GasthausWebApp3Bhwii.Models;

public class Bestellung
{
    public int bestellid { get; set; }
    public string preis { get; set; }
    public string menge { get; set; }
    public int mitarbeiterid { get; set; }
    public int tischid { get; set; }
    public int gastid { get; set; }
}