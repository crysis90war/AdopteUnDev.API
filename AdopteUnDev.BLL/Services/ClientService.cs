using AdopteUnDev.BLL.Entities;
using AdopteUnDev.BLL.Interfaces;
using AdopteUnDev.BLL.Mapper;
using AdopteUnDev.DAL.Interfaces;

namespace AdopteUnDev.BLL.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _ClientDalRepository;
        public ClientService(IClientRepository service)
        {
            _ClientDalRepository = service;
        }

        public ClientBllModel LoginClient(string email, string password)
        {
            return _ClientDalRepository.LoginClient(email, password)?.DalToBll();
        }

        public void RegisterClient(ClientBllModel entity)
        {
            _ClientDalRepository.RegisterClient(entity.BllToDal());
        }
    }
}
