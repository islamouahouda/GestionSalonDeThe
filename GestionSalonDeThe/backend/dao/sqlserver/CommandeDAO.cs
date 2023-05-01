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
        private readonly IBoissonDAO _boissonDAO;
        private readonly IServeurDAO _serveurDAO;

        public CommandeDAO(string connectionString, IBoissonDAO boissonDAO, IServeurDAO serveurDAO)
        {
            _connectionString = connectionString;
            _boissonDAO = boissonDAO;
            _serveurDAO = serveurDAO;

        }

        public void AddCommande(Commande commande)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Commandes (DateCom, HeureCom, IdServeur) OUTPUT INSERTED.IdCommande VALUES (@dateCom, @heureCom, @idServeur)", connection))
                {
                    command.Parameters.AddWithValue("@dateCom", commande.DateCom);
                    command.Parameters.AddWithValue("@heureCom", commande.HeureCom);
                    command.Parameters.AddWithValue("@idServeur", commande.IdServeur);

                    int newCommandeId = (int)command.ExecuteScalar(); // Récupérer l'ID de la nouvelle commande

                    // Enregistrer les boissons commandées
                    foreach (BoissonCommandee boissonCommandee in commande.BoissonsCommandees)
                    {
                        using (SqlCommand boissonCommand = new SqlCommand("INSERT INTO BoissonsCommandees (IdCommande, IdBoisson, QuantiteCommandee) VALUES (@idCommande, @idBoisson, @quantiteCommandee)", connection))
                        {
                            boissonCommand.Parameters.AddWithValue("@idCommande", newCommandeId);
                            boissonCommand.Parameters.AddWithValue("@idBoisson", boissonCommandee.IdBoisson);
                            boissonCommand.Parameters.AddWithValue("@quantiteCommandee", boissonCommandee.QuantiteCommandee);

                            boissonCommand.ExecuteNonQuery();
                        }
                    }
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

        //old description
        /*
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
        }*/
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

                        commande.Serveur = _serveurDAO.GetServeurById(commande.IdServeur);
                        commande.BoissonsCommandees = GetBoissonsCommandeesByCommandeId(commande.IdCommande);

                        commandes.Add(commande);
                    }
                }
            }

            return commandes;
        }


        // old description
        /*
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
        */
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

                        commande.Serveur = _serveurDAO.GetServeurById(commande.IdServeur);
                        commande.BoissonsCommandees = GetBoissonsCommandeesByCommandeId(commande.IdCommande);
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

        //default
        /*
        List<BoissonCommandee> ICommandeDAO.GetBoissonsCommandeesByCommandeId(int idCommande)
        {
            throw new NotImplementedException();
        }
        */

        //old description
        /*
        public List<BoissonCommandee> GetBoissonsCommandeesByCommandeId(int idCommande)
        {

            List<BoissonCommandee> boissonsCommandees = new List<BoissonCommandee>();

            using (SqlConnection connection = new SqlConnection("your_connection_string"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM BoissonsCommandees WHERE IdCommande = @IdCommande", connection))
                {
                    command.Parameters.AddWithValue("@IdCommande", idCommande);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BoissonCommandee boissonCommandee = new BoissonCommandee
                            {
                                IdCommande = reader.GetInt32(reader.GetOrdinal("IdCommande")),
                                IdBoisson = reader.GetInt32(reader.GetOrdinal("IdBoisson")),
                                QuantiteCommandee = reader.GetInt32(reader.GetOrdinal("QuantiteCommandee")),
                            };

                            boissonsCommandees.Add(boissonCommandee);
                        }
                    }
                }
            }

            return boissonsCommandees;
        }*/


        public List<BoissonCommandee> GetBoissonsCommandeesByCommandeId(int idCommande)
        {
            List<BoissonCommandee> boissonsCommandees = new List<BoissonCommandee>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"SELECT IdBoisson, IdCommande, QuantiteCommandee
                         FROM BoissonsCommandees
                         WHERE IdCommande = @IdCommande";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdCommande", idCommande);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idBoisson = reader.GetInt32(reader.GetOrdinal("IdBoisson"));
                            Boisson boisson = _boissonDAO.GetBoissonById(idBoisson);

                            BoissonCommandee boissonCommandee = new BoissonCommandee
                            {
                                IdBoisson = idBoisson,
                                Boisson = boisson,
                                IdCommande = reader.GetInt32(reader.GetOrdinal("IdCommande")),
                                QuantiteCommandee = reader.GetInt32(reader.GetOrdinal("QuantiteCommandee")),
                            };

                            boissonsCommandees.Add(boissonCommandee);
                        }
                    }
                }
            }

            return boissonsCommandees;
        }

    }
}
