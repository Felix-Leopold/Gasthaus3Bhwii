using GasthausWebApp3Bhwii.Models;
using Npgsql;

namespace GasthausWebApp3Bhwii.Repositories;

public class BestellungRepository
{
    private NpgsqlConnection ConnectToDB()
    {
        string connectionString = "Host=localhost;Database=gasthaus;User Id=dbuser;Password=2104;";
        NpgsqlConnection connection = new NpgsqlConnection(connectionString);
        connection.Open();
        return connection;
    }
    public List<Bestellung> GetAllBestellungen()
    {
        // Connect to DB
        NpgsqlConnection myConnection = ConnectToDB();
        //SQL Query ausführen
        using NpgsqlCommand cmd = new NpgsqlCommand("Select*from bestellung;", myConnection);

        using NpgsqlDataReader reader = cmd.ExecuteReader();

        List<Bestellung> bestellungs = new List<Bestellung>();
        while (reader.Read())
        {
            // Datensätzte in Objekte umwandeln
            Bestellung newBestellung = new Bestellung();
            newBestellung.bestellid = (int)reader["BestellId"];
            newBestellung.preis = (string)reader["Preis"];
            newBestellung.menge = (string)reader["Menge"];
            newBestellung.mitarbeiterid = (int)reader["MitarbeiterID"];
            newBestellung.tischid = (int)reader["TischId"];
            newBestellung.gastid = (int)reader["GastId"];

            
            bestellungs.Add(newBestellung);

        }
        
        myConnection.Close();
        // mit return zurückgeben

        return bestellungs;
    }

    public void CreateBestellung(Bestellung bestellung)
    {
        
    }

    public void DeleteBestellung(int bestellid)
    {
        
    }

    public void UpdateBestellung(Bestellung bestellung)
    {
        
    }
}