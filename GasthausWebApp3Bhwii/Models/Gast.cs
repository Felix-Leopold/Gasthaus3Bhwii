namespace GasthausWebApp3Bhwii.Models;

public class Gast
{
    public int Gastid { get; set; }
    public string vorname { get; set; }
    public string nachname { get; set; }
    public DateOnly aufenthaltdauer { get; set; }
}