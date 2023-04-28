using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using GestionSalonDeThe.BACKEND.ENTITIES;

namespace GestionSalonDeThe.backend.dao.sqlserver
{
    public class CommandeDAO : ICommandeDAO
    {
        private string _connectionString;

        public CommandeDAO(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddCommande(Commande commande)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Commandes (DateCom, HeureCom, IdServeur) VALUES (@dateCom, @heureCom, @idServeur)", connection))
                {
                    command.Parameters.AddWithValue("@dateCom", commande.DateCom);
                    command.Parameters.AddWithValue("@heureCom", commande.HeureCom);
                    command.Parameters.AddWithValue("@idServeur", commande.IdServeur);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteCommande(int idCommande)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM Commandes WHERE IdCommande = @idCommande", connection))
                {
                    command.Parameters.AddWithValue("@idCommande", idCommande);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Commande> GetAllCommandes()
        {
            List<Commande> commandes = new List<Commande>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Commandes", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Commande commande = new Commande
                        {
                            IdCommande = (int)reader["IdCommande"],
                            DateCom = (DateTime)reader["DateCom"],
                            HeureCom = (TimeSpan)reader["HeureCom"],
                            IdServeur = (int)reader["IdServeur"]
                        };

                        commandes.Add(commande);
                    }
                }
            }

            return commandes;
        }

        public Commande GetCommandeById(int idCommande)
        {
            Commande commande = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Commandes WHERE IdCommande = @idCommande", connection))
                {
                    command.Parameters.AddWithValue("@idCommande", idCommande);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        commande = new Commande
                        {
                            IdCommande = (int)reader["IdCommande"],
                            DateCom = (DateTime)reader["DateCom"],
                            HeureCom = (TimeSpan)reader["HeureCom"],
                            IdServeur = (int)reader["IdServeur"]
                        };
                    }
                }
            }

            return commande;
        }

        public void UpdateCommande(Commande commande)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Commandes SET DateCom = @dateCom, HeureCom = @heureCom, IdServeur = @idServeur WHERE IdCommande = @idCommande", connection))
                {
                    command.Parameters.AddWithValue("@idCommande", commande.IdCommande);
                    command.Parameters.AddWithValue("@dateCom", commande.DateCom);
                    command.Parameters.AddWithValue("@heureCom", commande.HeureCom);
                    command.Parameters.AddWithValue("@idServeur", commande.IdServeur);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
