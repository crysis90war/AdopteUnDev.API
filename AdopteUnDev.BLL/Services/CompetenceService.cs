using AdopteUnDev.BLL.Interfaces;
using AdopteUnDev.BLL.Mapper;
using AdopteUnDev.BLL.Models;
using AdopteUnDev.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.BLL.Services
{
    public class CompetenceService : ICompetenceService
    {
        private readonly ICompetenceRepository _competenceRepository;

        public CompetenceService(ICompetenceRepository service)
        {
            _competenceRepository = service;
        }

        public void AddCompetence(CompetenceBllModel model)
        {
            _competenceRepository.AddCompetence(model.BllToDal());
        }

        public void DeleteCompetence(int Id)
        {
            _competenceRepository.DeleteCompetence(Id);
        }

        public IEnumerable<CompetenceBllModel> GetAllCompetence()
        {
            return _competenceRepository.GetAllCompetence().Select(c => c.DalToBll());
        }

        #region CRUD COMPLET
        public IEnumerable<CompetenceBllModel> GetAll()
        {
            return _competenceRepository.GetAll().Select(x => x.DalToBll());
        }

        public CompetenceBllModel GetById(int id)
        {
            return _competenceRepository.GetById(id).DalToBll();
        }

        public void Create(CompetenceBllModel model)
        {
            _competenceRepository.Create(model.BllToDal());
        }

        public void Update(int id, CompetenceBllModel model)
        {
            _competenceRepository.Update(id, model.BllToDal());
        }

        public void Delete(int id)
        {
            _competenceRepository.Delete(id);
        }
        #endregion
    }
}
