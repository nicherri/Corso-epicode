using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SpedizioniWebApp.Models;
using System.Data.SqlClient;

[Authorize(Roles = "Admin,Business")]
public class ClientiController : Controller
{
    private readonly string _connectionString = "your_connection_string_here";

    public IActionResult Index()
    {
        var clienti = new List<Cliente>();

        using (var con = new SqlConnection(_connectionString))
        {
            var query = "SELECT * FROM Clienti";
            var cmd = new SqlCommand(query, con);
            con.Open();
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var cliente = new Cliente
                {
                    Id = (int)reader["Id"],
                    Nome = reader["Nome"].ToString(),
                    Cognome = reader["Cognome"].ToString(),
                    CodiceFiscale = reader["CodiceFiscale"].ToString(),
                    PartitaIVA = reader["PartitaIVA"].ToString(),
                    TipoCliente = reader["TipoCliente"].ToString()
                };
                clienti.Add(cliente);
            }
        }

        return View(clienti);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Cliente cliente)
    {
        using (var con = new SqlConnection(_connectionString))
        {
            var query = "INSERT INTO Clienti (Nome, Cognome, CodiceFiscale, PartitaIVA, TipoCliente) " +
                           "VALUES (@Nome, @Cognome, @CodiceFiscale, @PartitaIVA, @TipoCliente)";
            var cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Cognome", cliente.Cognome);
            cmd.Parameters.AddWithValue("@CodiceFiscale", cliente.CodiceFiscale);
            cmd.Parameters.AddWithValue("@PartitaIVA", cliente.PartitaIVA);
            cmd.Parameters.AddWithValue("@TipoCliente", cliente.TipoCliente);

            con.Open();
            cmd.ExecuteNonQuery();
        }

        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        Cliente cliente = null;

        using (var con = new SqlConnection(_connectionString))
        {
            var query = "SELECT * FROM Clienti WHERE Id = @Id";
            var cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                cliente = new Cliente
                {
                    Id = (int)reader["Id"],
                    Nome = reader["Nome"].ToString(),
                    Cognome = reader["Cognome"].ToString(),
                    CodiceFiscale = reader["CodiceFiscale"].ToString(),
                    PartitaIVA = reader["PartitaIVA"].ToString(),
                    TipoCliente = reader["TipoCliente"].ToString()
                };
            }
        }

        if (cliente == null)
        {
            return NotFound();
        }

        return View(cliente);
    }

    [HttpPost]
    public IActionResult Edit(Cliente cliente)
    {
        using (var con = new SqlConnection(_connectionString))
        {
            var query = "UPDATE Clienti SET Nome = @Nome, Cognome = @Cognome, CodiceFiscale = @CodiceFiscale, PartitaIVA = @PartitaIVA, TipoCliente = @TipoCliente WHERE Id = @Id";
            var cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", cliente.Id);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Cognome", cliente.Cognome);
            cmd.Parameters.AddWithValue("@CodiceFiscale", cliente.CodiceFiscale);
            cmd.Parameters.AddWithValue("@PartitaIVA", cliente.PartitaIVA);
            cmd.Parameters.AddWithValue("@TipoCliente", cliente.TipoCliente);

            con.Open();
            cmd.ExecuteNonQuery();
        }

        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        Cliente cliente = null;

        using (var con = new SqlConnection(_connectionString))
        {
            var query = "SELECT * FROM Clienti WHERE Id = @Id";
            var cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                cliente = new Cliente
                {
                    Id = (int)reader["Id"],
                    Nome = reader["Nome"].ToString(),
                    Cognome = reader["Cognome"].ToString(),
                    CodiceFiscale = reader["CodiceFiscale"].ToString(),
                    PartitaIVA = reader["PartitaIVA"].ToString(),
                    TipoCliente = reader["TipoCliente"].ToString()
                };
            }
        }

        if (cliente == null)
        {
            return NotFound();
        }

        return View(cliente);
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        using (var con = new SqlConnection(_connectionString))
        {
            var query = "DELETE FROM Clienti WHERE Id = @Id";
            var cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            cmd.ExecuteNonQuery();
        }

        return RedirectToAction("Index");
    }
}
