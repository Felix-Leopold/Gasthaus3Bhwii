using System.Runtime.InteropServices.JavaScript;

namespace GasthausWebApp3Bhwii.Models;

public class Mitarbeiter
{
    public int mitarbeiterid { get; set; }
    public string vorname { get; set; }
    public string nachname { get; set; }
    public DateTime geburtsdatum { get; set; }
}