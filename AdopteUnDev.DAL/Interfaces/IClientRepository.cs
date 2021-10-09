using AdopteUnDev.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.DAL.Interfaces
{
    public interface IClientRepository
    {
        ClientEntity LoginClient(string email, string password);
        void RegisterClient(ClientEntity entity);
    }
}
