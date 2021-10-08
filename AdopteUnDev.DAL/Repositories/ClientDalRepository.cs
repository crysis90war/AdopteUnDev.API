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
    public class ClientDalRepository : IClientDalRepository
    {
        private readonly Connection _connection;

        public ClientDalRepository(Connection connection)
        {
            _connection = connection;
        }

        public ClientDalEntity LoginClient(string email, string password)
        {
            Command command = new Command("spClientLogin", true);
            command.AddParameter("email", email);
            command.AddParameter("password", password);

            return _connection.ExecuteReader(command, dr => dr.DBToDALClientEntity()).SingleOrDefault();
        }

        public void RegisterClient(ClientDalEntity entity)
        {
            Command command = new Command("dbo.spClientRegister", true);
            command.AddParameter("LastName", entity.LastName);
            command.AddParameter("FirstName", entity.FirstName);
            command.AddParameter("Compagny", entity.Compagny);
            command.AddParameter("Tel", entity.Tel);
            command.AddParameter("Email", entity.Email);
            command.AddParameter("Password", entity.Pswd);
            _connection.ExecuteNonQuery(command);
        }
    }
}
