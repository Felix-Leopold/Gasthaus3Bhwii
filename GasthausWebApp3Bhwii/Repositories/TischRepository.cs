using GasthausWebApp3Bhwii.Models;
using Npgsql;

namespace GasthausWebApp3Bhwii.Repositories;

public class TischRepository
{

    private NpgsqlConnection ConnectToDB()
    {
        string connectionString = "Host=localhost;Database=gasthaus;User Id=dbuser;Password=2104;";
        NpgsqlConnection connection = new NpgsqlConnection(connectionString);
        connection.Open();
        return connection;
    }
    public List<Tisch> GetAllTisches()
    {
        // Connect to DB
        NpgsqlConnection myConnection = ConnectToDB();
        //SQL Query ausführen
        using NpgsqlCommand cmd = new NpgsqlCommand("Select*from tisch;", myConnection);

        using NpgsqlDataReader reader = cmd.ExecuteReader();

        List<Tisch> tisches = new List<Tisch>();
        while (reader.Read())
        {
            // Datensätzte in Objekte umwandeln
            Tisch newTisch = new Tisch();
            newTisch.Tischid = (int)reader["TischId"];
            newTisch.laenge = (double)reader["laenge"];
            newTisch.breite = (double)reader["breite"];
            newTisch.hoehe = (double)reader["hoehe"];
            
            tisches.Add(newTisch);

        }
        
        myConnection.Close();
        // mit return zurückgeben

        return tisches;
    }

    public void CreateTisch(Tisch tisch)
    {
        
    }

    public void DeleteTisch(int tischid)
    {
        
    }

    public void UpdateTisch(Tisch tisch)
    {
        
    }
}