using AdopteUnDev.BLL.Entities;
using AdopteUnDev.BLL.Interfaces;
using AdopteUnDev.BLL.Mapper;
using AdopteUnDev.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.BLL.Repositories
{
    public class ClientBllRepository : IClientBllRepository
    {
        private readonly IClientDalRepository _ClientDalRepository;
        public ClientBllRepository(IClientDalRepository service)
        {
            _ClientDalRepository = service;
        }

        public ClientBllModel LoginClient(string email, string password)
        {
            return _ClientDalRepository.LoginClient(email, password)?.ClientDalToClientBll();
        }

        public void RegisterClient(ClientBllModel entity)
        {
            _ClientDalRepository.RegisterClient(entity.ClientBllToClientDal());
        }
    }
}
