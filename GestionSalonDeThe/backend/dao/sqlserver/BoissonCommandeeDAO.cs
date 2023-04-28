using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using GestionSalonDeThe.BACKEND.ENTITIES;

namespace GestionSalonDeThe.backend.dao.sqlserver
{
    public class BoissonCommandeeDAO : IBoissonCommandeeDAO
    {
        private string _connectionString;

        public BoissonCommandeeDAO(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<BoissonCommandee> GetAllBoissonsCommandees()
        {
            List<BoissonCommandee> boissonsCommandees = new List<BoissonCommandee>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM BoissonsCommandees", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        BoissonCommandee boissonCommandee = new BoissonCommandee
                        {
                            IdBoisson = (int)reader["IdBoisson"],
                            IdCommande = (int)reader["IdCommande"],
                            QuantiteCommandee = (int)reader["QuantiteCommandee"]
                        };

                        boissonsCommandees.Add(boissonCommandee);
                    }
                }
            }

            return boissonsCommandees;
        }

        public BoissonCommandee GetBoissonCommandee(int idBoisson, int idCommande)
        {
            BoissonCommandee boissonCommandee = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM BoissonsCommandees WHERE IdBoisson = @idBoisson AND IdCommande = @idCommande", connection))
                {
                    command.Parameters.AddWithValue("@idBoisson", idBoisson);
                    command.Parameters.AddWithValue("@idCommande", idCommande);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        boissonCommandee = new BoissonCommandee
                        {
                            IdBoisson = (int)reader["IdBoisson"],
                            IdCommande = (int)reader["IdCommande"],
                            QuantiteCommandee = (int)reader["QuantiteCommandee"]
                        };
                    }
                }
            }

            return boissonCommandee;
        }

        public void AddBoissonCommandee(BoissonCommandee boissonCommandee)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO BoissonsCommandees (IdBoisson, IdCommande, QuantiteCommandee) VALUES (@idBoisson, @idCommande, @quantiteCommandee)", connection))
                {
                    command.Parameters.AddWithValue("@idBoisson", boissonCommandee.IdBoisson);
                    command.Parameters.AddWithValue("@idCommande", boissonCommandee.IdCommande);
                    command.Parameters.AddWithValue("@quantiteCommandee", boissonCommandee.QuantiteCommandee);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateBoissonCommandee(BoissonCommandee boissonCommandee)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE BoissonsCommandees SET QuantiteCommandee = @quantiteCommandee WHERE IdBoisson = @idBoisson AND IdCommande = @idCommande", connection))
                {
                    command.Parameters.AddWithValue("@idBoisson", boissonCommandee.IdBoisson);
                    command.Parameters.AddWithValue("@idCommande", boissonCommandee.IdCommande);
                    command.Parameters.AddWithValue("@quantiteCommandee", boissonCommandee.QuantiteCommandee);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteBoissonCommandee(int idBoisson, int idCommande)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM BoissonsCommandees WHERE IdBoisson = @idBoisson AND IdCommande = @idCommande", connection))
                {
                    command.Parameters.AddWithValue("@idBoisson", idBoisson);
                    command.Parameters.AddWithValue("@idCommande", idCommande);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
