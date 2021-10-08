using AdopteUnDev.BLL.Entities;
using AdopteUnDev.BLL.Interfaces;
using AdopteUnDev.BLL.Mapper;
using AdopteUnDev.BLL.Models;
using AdopteUnDev.DAL.Interfaces;
using AdopteUnDev.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.BLL.Services
{
    public class DeveloppeurBllRepository : IDeveloppeurBllRepository
    {
        private readonly IDeveloppeurDalRepository _DeveloppeurDalRepository;
        public DeveloppeurBllRepository(IDeveloppeurDalRepository service)
        {
            _DeveloppeurDalRepository = service;
        }


        public DeveloppeurBllModel GetByCompetenceId(int Id)
        {
            //return _DeveloppeurDalRepository.GetByCompetenceId(Id)?.DevDalToClientBll();
            throw new NotImplementedException();
        }

        public DeveloppeurBllModel LoginDev(string email, string password)
        {
            return _DeveloppeurDalRepository.LoginDev(email, password)?.DevDalToDevBll();
        }

        public void RegisterDev(DeveloppeurBllModel entity)
        {
            _DeveloppeurDalRepository.RegisterDev(entity.DevBllToDevDal());
        }

        public void SetCompetence(int Id, CompetenceBllModel Competence)
        {
            _DeveloppeurDalRepository.SetCompetence(Id, Competence.CompetenceBllToCompetenceDal());
        }
    }
}
