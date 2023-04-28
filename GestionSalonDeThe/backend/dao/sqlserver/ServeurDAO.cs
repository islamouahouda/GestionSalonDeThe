using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using GestionSalonDeThe.BACKEND.ENTITIES;

namespace GestionSalonDeThe.backend.dao.sqlserver
{
    public class ServeurDAO : IServeurDAO
    {
        private string _connectionString;

        public ServeurDAO(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Serveur> GetAllServeurs()
        {
            List<Serveur> serveurs = new List<Serveur>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Serveurs", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Serveur serveur = new Serveur
                        {
                            IdServeur = (int)reader["IdServeur"],
                            Nom = (string)reader["Nom"],
                            Prenom = (string)reader["Prenom"]
                        };

                        serveurs.Add(serveur);
                    }
                }
            }

            return serveurs;
        }

        public Serveur GetServeurById(int idServeur)
        {
            Serveur serveur = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Serveurs WHERE IdServeur = @idServeur", connection))
                {
                    command.Parameters.AddWithValue("@idServeur", idServeur);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        serveur = new Serveur
                        {
                            IdServeur = (int)reader["IdServeur"],
                            Nom = (string)reader["Nom"],
                            Prenom = (string)reader["Prenom"]
                        };
                    }
                }
            }

            return serveur;
        }

        public void AddServeur(Serveur serveur)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Serveurs (Nom, Prenom) VALUES (@nom, @prenom)", connection))
                {
                    command.Parameters.AddWithValue("@nom", serveur.Nom);
                    command.Parameters.AddWithValue("@prenom", serveur.Prenom);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateServeur(Serveur serveur)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Serveurs SET Nom = @nom, Prenom = @prenom WHERE IdServeur = @idServeur", connection))
                {
                    command.Parameters.AddWithValue("@idServeur", serveur.IdServeur);
                    command.Parameters.AddWithValue("@nom", serveur.Nom);
                    command.Parameters.AddWithValue("@prenom", serveur.Prenom);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteServeur(int idServeur)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM Serveurs WHERE IdServeur = @idServeur", connection))
                {
                    command.Parameters.AddWithValue("@idServeur", idServeur);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
