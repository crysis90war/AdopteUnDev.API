using AdopteUnDev.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.BLL.Interfaces
{
    public interface IClientService
    {
        ClientBllModel LoginClient(string email, string password);
        void RegisterClient(ClientBllModel entity);
    }
}
