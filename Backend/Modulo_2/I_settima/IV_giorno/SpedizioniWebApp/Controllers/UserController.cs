using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SpedizioniWebApp.Models;
using System.Data.SqlClient;

[Authorize(Roles = "User")]
public class UserController : Controller
{
    private readonly string _connectionString = "your_connection_string_here";

    [HttpGet]
    public IActionResult VerificaSpedizione()
    {
        return View();
    }

    [HttpPost]
    public IActionResult VerificaSpedizione(string codice, string numeroSpedizione)
    {
        var aggiornamenti = new List<AggiornamentoSpedizione>();

        using (var con = new SqlConnection(_connectionString))
        {
            var query = "SELECT a.* FROM AggiornamentiSpedizioni a JOIN Spedizioni s ON a.SpedizioneId = s.Id " +
                        "JOIN Clienti c ON s.ClienteId = c.Id WHERE (c.CodiceFiscale = @Codice OR c.PartitaIVA = @Codice) " +
                        "AND s.NumeroIdentificativo = @NumeroSpedizione ORDER BY a.DataOra DESC";
            var cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Codice", codice);
            cmd.Parameters.AddWithValue("@NumeroSpedizione", numeroSpedizione);

            con.Open();
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var aggiornamento = new AggiornamentoSpedizione
                {
                    Id = (int)reader["Id"],
                    SpedizioneId = (int)reader["SpedizioneId"],
                    Stato = reader["Stato"].ToString(),
                    Luogo = reader["Luogo"].ToString(),
                    Descrizione = reader["Descrizione"].ToString(),
                    DataOra = (DateTime)reader["DataOra"]
                };
                aggiornamenti.Add(aggiornamento);
            }
        }

        return View("VisualizzaAggiornamenti", aggiornamenti);
    }
}
