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
    public class CompetenceDalRepository : ICompetenceDalRepository
    {
        private readonly Connection _connection;

        public CompetenceDalRepository(Connection connection)
        {
            _connection = connection;
        }

        public void AddCompetence( CompetenceDalEntity Competence)
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

        public IEnumerable<CompetenceDalEntity> GetAllCompetence()
        {
            Command command = new Command("Select * FROM Competences");
            return _connection.ExecuteReader(command, er => er.DBToDALCompEntity());
        }

        public void SetCompetencebyDev(CompetenceDalEntity Competence, int DevId)
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
