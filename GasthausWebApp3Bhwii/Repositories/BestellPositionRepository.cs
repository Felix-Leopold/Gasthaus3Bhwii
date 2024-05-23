using GasthausWebApp3Bhwii.Models;
using Npgsql;

namespace GasthausWebApp3Bhwii.Repositories;

public class BestellungPositionRepository
{
    private NpgsqlConnection ConnectToDB()
    {
        string connectionString = "Host=localhost;Database=gasthaus;User Id=dbuser;Password=2104;";
        NpgsqlConnection connection = new NpgsqlConnection(connectionString);
        connection.Open();
        return connection;
    }
    public List<BestellPosition> GetAllBestellPositionen()
    {
        // Connect to DB
        NpgsqlConnection myConnection = ConnectToDB();
        //SQL Query ausführen
        using NpgsqlCommand cmd = new NpgsqlCommand("Select*from bestellposition;", myConnection);

        using NpgsqlDataReader reader = cmd.ExecuteReader();

        List<BestellPosition> bestellPositions = new List<BestellPosition>();
        while (reader.Read())
        {
            // Datensätzte in Objekte umwandeln
            BestellPosition newBestellPosition = new BestellPosition();
            newBestellPosition.bestellpositionid = (int)reader["BestellPositionid"];
            newBestellPosition.produktid = (int)reader["Produktid"];
            newBestellPosition.bestellid = (int)reader["Bestellid"];
            

            
            bestellPositions.Add(newBestellPosition);

        }
        
        myConnection.Close();
        // mit return zurückgeben

        return bestellPositions;
    }

    public void CreateBestellPosition(BestellPosition bestellPosition)
    {
        
    }

    public void DeleteBestellPosition(int bestellpositionid)
    {
        
    }

    public void UpdateBestellPosition(BestellPosition bestellPosition)
    {
        
    }
}