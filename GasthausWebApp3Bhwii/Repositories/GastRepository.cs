using GasthausWebApp3Bhwii.Models;
using Npgsql;

namespace GasthausWebApp3Bhwii.Repositories;

public class GastRepository
{
    private NpgsqlConnection ConnectToDB()
    {
        string connectionString = "Host=localhost;Database=gasthaus;User Id=dbuser;Password=2104;";
        NpgsqlConnection connection = new NpgsqlConnection(connectionString);
        connection.Open();
        return connection;
    }
    public List<Gast> GetAllGaeste()
    {
        // Connect to DB
        NpgsqlConnection myConnection = ConnectToDB();
        //SQL Query ausführen
        using NpgsqlCommand cmd = new NpgsqlCommand("Select*from gast;", myConnection);

        using NpgsqlDataReader reader = cmd.ExecuteReader();

        List<Gast> gasts = new List<Gast>();
        while (reader.Read())
        {
            // Datensätzte in Objekte umwandeln
            Gast newGast = new Gast();
            newGast.Gastid = (int)reader["GastId"];
            newGast.vorname = (string)reader["Vorname"];
            newGast.nachname = (string)reader["Nachname"];
            newGast.aufenthaltsdauer = (TimeOnly)reader["Aufenthaltsdauer"];
            
            gasts.Add(newGast);

        }
        
        myConnection.Close();
        // mit return zurückgeben

        return gasts;
    }

    public void CreateGast(Gast gast)
    {
        
    }

    public void DeleteGast(int gastid)
    {
        
    }

    public void UpdateGast(Gast gast)
    {
        
    }
}