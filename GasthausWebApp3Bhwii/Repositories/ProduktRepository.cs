using GasthausWebApp3Bhwii.Models;
using Npgsql;

namespace GasthausWebApp3Bhwii.Repositories;

public class ProduktRepository
{

    private NpgsqlConnection ConnectToDB()
    {
        string connectionString = "Host=localhost;Database=gasthaus;User Id=dbuser;Password=2104;";
        NpgsqlConnection connection = new NpgsqlConnection(connectionString);
        connection.Open();
        return connection;
    }
    public List<Produkt> GetAllProdukts()
    {
        // Connect to DB
        NpgsqlConnection myConnection = ConnectToDB();
        //SQL Query ausführen
        using NpgsqlCommand cmd = new NpgsqlCommand("Select*from produkt;", myConnection);

        using NpgsqlDataReader reader = cmd.ExecuteReader();

        List<Produkt> produkts = new List<Produkt>();
        while (reader.Read())
        {
            // Datensätzte in Objekte umwandeln
            Produkt newProdukt = new Produkt();
            newProdukt.produktid = (int)reader["produktid"];
            newProdukt.bezeichnung = (string)reader["bezeichung"];
            newProdukt.preis = (double)reader["preis"];
            newProdukt.typ = (string)reader["typ"];
            
            produkts.Add(newProdukt);

        }
        
        myConnection.Close();
        // mit return zurückgeben

        return produkts ;
    }

    public void CreateProdukt(Produkt produkt)
    {
        
    }

    public void DeleteProdukt(int produktid)
    {
        
    }

    public void UpdateProdukt(Produkt produkt)
    {
        
    }
}