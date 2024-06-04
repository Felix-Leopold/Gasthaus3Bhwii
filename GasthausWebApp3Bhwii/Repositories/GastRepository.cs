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
            newGast.Gastid = (int)reader["gastid"];
            newGast.vorname = (string)reader["vorname"];
            newGast.nachname = (string)reader["nachname"];
            newGast.aufenthaltdauer = (TimeSpan)reader["aufenthaltdauer"];
            
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