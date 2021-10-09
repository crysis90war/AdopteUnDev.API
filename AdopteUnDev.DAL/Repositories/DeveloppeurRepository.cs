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
    public class DeveloppeurRepository : IDeveloppeurRepository
    {
        private readonly Connection _connection;

        public DeveloppeurRepository(Connection connection)
        {
            _connection = connection;
        }

        public CompetenceEntity GetByCompetenceId(int Id)
        {
            Command command = new Command("SELECT * FROM Competence WHERE Id=@Id");
            command.AddParameter("Id", Id);
            return _connection.ExecuteReader(command, dr => dr.DbToCompetence()).FirstOrDefault();
        }

        public DeveloppeurEntity LoginDev(string email, string password)
        {
            Command command = new Command("spClientLogin", true);
            command.AddParameter("email", email);
            command.AddParameter("password", password);

            return _connection.ExecuteReader(command, dr => dr.DbToDeveloppeur()).SingleOrDefault();

        }

        public void RegisterDev(DeveloppeurEntity entity)
        {
            Command command = new Command("dbo.spDeveloppeurRegister", true);
            command.AddParameter("LastName", entity.LastName);
            command.AddParameter("FirstName", entity.FirstName);
            command.AddParameter("BirthDate", entity.BirthDate);
            command.AddParameter("Tel", entity.Tel);
            command.AddParameter("email", entity.Email);
            command.AddParameter("Password", entity.Pswd);
            _connection.ExecuteNonQuery(command);
        }

        public void SetCompetence(int Id, CompetenceEntity Competence)
        {
            Command command = new Command("UPDATE Competences SET Nom = @Nom WHERE Id=@Id");
            command.AddParameter("Id", Id);
            command.AddParameter("Nom", Competence.Nom);
            _connection.ExecuteNonQuery(command);
        }
    }
}
