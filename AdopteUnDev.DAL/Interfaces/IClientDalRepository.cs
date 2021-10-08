using AdopteUnDev.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.DAL.Interfaces
{
    public interface IClientDalRepository
    {
        ClientDalEntity LoginClient(string email, string password);
        void RegisterClient(ClientDalEntity entity);
    }
}
