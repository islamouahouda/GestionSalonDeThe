using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using GestionSalonDeThe.BACKEND.ENTITIES;

namespace GestionSalonDeThe.backend.dao.sqlserver
{
    public class BoissonDAO : IBoissonDAO
    {
        private string _connectionString;

        public BoissonDAO(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddBoisson(Boisson boisson)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Boissons (Designation, Prix, QteStock) VALUES (@designation, @prix, @qteStock)", connection))
                {
                    command.Parameters.AddWithValue("@designation", boisson.Designation);
                    command.Parameters.AddWithValue("@prix", boisson.Prix);
                    command.Parameters.AddWithValue("@qteStock", boisson.QteStock);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteBoisson(int idBoisson)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM Boissons WHERE IdBoisson = @idBoisson", connection))
                {
                    command.Parameters.AddWithValue("@idBoisson", idBoisson);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Boisson> GetAllBoissons()
        {
            List<Boisson> boissons = new List<Boisson>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Boissons", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Boisson boisson = new Boisson
                        {
                            IdBoisson = (int)reader["IdBoisson"],
                            Designation = (string)reader["Designation"],
                            Prix = (decimal)reader["Prix"],
                            QteStock = (int)reader["QteStock"]
                        };

                        boissons.Add(boisson);
                    }
                }
            }

            return boissons;
        }

        public Boisson GetBoissonById(int idBoisson)
        {
            Boisson boisson = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Boissons WHERE IdBoisson = @idBoisson", connection))
                {
                    command.Parameters.AddWithValue("@idBoisson", idBoisson);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        boisson = new Boisson
                        {
                            IdBoisson = (int)reader["IdBoisson"],
                            Designation = (string)reader["Designation"],
                            Prix = (decimal)reader["Prix"],
                            QteStock = (int)reader["QteStock"]
                        };
                    }
                }
            }

            return boisson;
        }

        public void UpdateBoisson(Boisson boisson)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Boissons SET Designation = @designation, Prix = @prix, QteStock = @qteStock WHERE IdBoisson = @idBoisson", connection))
                {
                    command.Parameters.AddWithValue("@idBoisson", boisson.IdBoisson);
                    command.Parameters.AddWithValue("@designation", boisson.Designation);
                    command.Parameters.AddWithValue("@prix", boisson.Prix);
                    command.Parameters.AddWithValue("@qteStock", boisson.QteStock);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
