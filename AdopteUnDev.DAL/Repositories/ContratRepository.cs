using AdopteUnDev.DAL.Entities;
using AdopteUnDev.DAL.Interfaces;
using AdopteUnDev.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Connection;

namespace AdopteUnDev.DAL.Repositories
{
    public class ContratRepository : IContratRepository
    {
        private readonly Connection _connection;

        public ContratRepository(Connection connection)
        {
            _connection = connection;
        }

        public void AcceptContrat(bool Accept, int Id)
        {
            // ! dans les requettes sql le true false se set avec 1 ou 0  
            if (Accept)
            {
                Command command = new Command("UPDATE Contrats SET Statut = 1 WHERE Id = @Id");
                command.AddParameter("Id", Id);
                _connection.ExecuteNonQuery(command);
            }
        }

        public void DeclineContrat(bool Decline, int Id)
        {
            if (Decline)
            {
                Command command = new Command("UPDATE Contrats SET Statut = 0 WHERE Id = @Id");
                command.AddParameter("Id", Id);
                _connection.ExecuteNonQuery(command);
            }
        }

        public void AddContrat(ContratEntity contrat)
        {
            Command command = new Command("spAddContrat", true);
            command.AddParameter("Intituler", contrat.Intituler);
            command.AddParameter("Duree", contrat.Duree);
            command.AddParameter("Description", contrat.Description);
            _connection.ExecuteNonQuery(command);
        }

        public void DeleteContrat(int Id)
        {
            Command command = new Command("spDeleteContrat", true);
            command.AddParameter("Id", Id);
            _connection.ExecuteNonQuery(command);
        }

        /*public ClientDalEntity GetByClientId(int Id)
        {
            Command command = new Command("SELECT * FROM Client WHERE Id=@Id");
            command.AddParameter("Id", Id);
            return _connection.ExecuteReader(command, er => er.DBToDALClientEntity()).FirstOrDefault();
        }

        public DeveloppeurDalEntity GetByDevId(int Id)
        {
            Command command = new Command("SELECT * FROM Developpeurs WHERE Id=@Id");
            command.AddParameter("Id", Id);
            return _connection.ExecuteReader(command, er => er.DBToDALDevEntity()).FirstOrDefault();
        }*/
    }
}
