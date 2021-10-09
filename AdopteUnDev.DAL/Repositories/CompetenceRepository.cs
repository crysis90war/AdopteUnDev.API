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
    public class CompetenceRepository : ICompetenceRepository
    {
        private readonly Connection _connection;

        public CompetenceRepository(Connection connection)
        {
            _connection = connection;
        }

        public void Create(CompetenceEntity entity)
        {
            string query = "INSERT INTO dbo.Competences (Nom) VALUES (@Nom)";
            Command command = new("spCompetences_Insert", true);
            command.AddParameter("Nom", entity.Nom);
            command.AddParameter("Id", 0);
            _connection.ExecuteNonQuery(command);
        }

        public IEnumerable<CompetenceEntity> GetAll()
        {
            Command command = new Command("Select * FROM Competences");
            return _connection.ExecuteReader(command, dr => dr.DbToCompetence());
        }

        public CompetenceEntity GetById(int id)
        {
            Command command = new("SELECT * FROM Competences WHERE Id = @Id");
            command.AddParameter("Id", id);
            return _connection.ExecuteReader(command, dr => dr.DbToCompetence()).SingleOrDefault();
        }

        public void Update(int id, CompetenceEntity entity)
        {
            Command command = new("UPDATE Competences SET Nom = @Nom WHERE Id = @Id");
            command.AddParameter("Nom", entity.Nom);
            command.AddParameter("Id", id);
            _connection.ExecuteNonQuery(command);
        }

        public void Delete(int id)
        {
            Command command = new Command("DELETE FROM Competences WHERE Id = @Id");
            command.AddParameter("Id", id);
            _connection.ExecuteNonQuery(command);
        }

        public IEnumerable<CompetenceEntity> GetAllCompetence()
        {
            Command command = new Command("Select * FROM Competences");
            return _connection.ExecuteReader(command, er => er.DbToCompetence());
        }

        public void AddCompetence( CompetenceEntity Competence)
        {
            Command command = new Command("spAddCompetence", true);
            command.AddParameter("Nom", Competence.Nom);
            _connection.ExecuteNonQuery(command);
        }

        public void DeleteCompetence(int Id)
        {
            Command command = new Command("Delete * FROM Competence WHERE Id = @Id");
            command.AddParameter("Id", Id);
            _connection.ExecuteNonQuery(command);
        }

        public void SetCompetencebyDev(CompetenceEntity Competence, int DevId)
        {
            /*Command command = new Command("INSERT INTO Competence " +
                                            "Join MtmDevCom ON id Dev= idMTNDEV " +
                                            "JOIN Dev ON IDDEV= MTNIDDEV Nom " +
                                            "VALUES Nom");*/

            Command command = new Command("INSERT INTO Competence " +
                                          "Join MtmDevCom AS mdc ON d.id = mdc.DeveloppeurId " +
                                          "JOIN Developpeurs AS d ON d.id = mdc.DeveloppeurId.Nom " +
                                          "VALUES Nom");
            command.AddParameter("Nom", Competence.Nom);
            command.AddParameter("DevId", DevId);
        }
    }
}
