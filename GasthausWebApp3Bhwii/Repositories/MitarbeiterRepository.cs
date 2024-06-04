using GasthausWebApp3Bhwii.Models;
using Npgsql;

namespace GasthausWebApp3Bhwii.Repositories;

public class MitarbeiterRepository
{

    private NpgsqlConnection ConnectToDB()
    {
        string connectionString = "Host=localhost;Database=gasthaus;User Id=dbuser;Password=2104;";
        NpgsqlConnection connection = new NpgsqlConnection(connectionString);
        connection.Open();
        return connection;
    }
    public List<Mitarbeiter> GetAllMitarbeiter()
    {
        // Connect to DB
        NpgsqlConnection myConnection = ConnectToDB();
        //SQL Query ausführen
        using NpgsqlCommand cmd = new NpgsqlCommand("Select*from mitarbeiter;", myConnection);

        using NpgsqlDataReader reader = cmd.ExecuteReader();

        List<Mitarbeiter> mitarbeiters = new List<Mitarbeiter>();
        while (reader.Read())
        {
            // Datensätzte in Objekte umwandeln
            Mitarbeiter newMitarbeiter = new Mitarbeiter();
            newMitarbeiter.mitarbeiterid = (int)reader["mitarbeiterid"];
            newMitarbeiter.vorname = (string)reader["vorname"];
            newMitarbeiter.nachname = (string)reader["nachname"];
            newMitarbeiter.geburtsdatum = (DateTime)reader["geburtsdatum"];
            
            mitarbeiters.Add(newMitarbeiter);

        }
        
        myConnection.Close();
        // mit return zurückgeben

        return mitarbeiters;
    }

    public void CreateMitarbeiter(Mitarbeiter mitarbeiter)
    {
        
    }

    public void DeleteMitarbeiter(int mitarbeiterid)
    {
        
    }

    public void UpdateMitarbeiter(Mitarbeiter mitarbeiter)
    {
        
    }
}