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
    public class CompetenceBllRepository : ICompetenceBllRepository
    {
        private readonly ICompetenceDalRepository _CompetenceDalRepository;
        public CompetenceBllRepository(ICompetenceDalRepository service)
        {
            _CompetenceDalRepository = service;
        }

        public void AddCompetence(CompetenceBllModel Competence)
        {
            _CompetenceDalRepository.AddCompetence(Competence.CompetenceBllToCompetenceDal());
        }

        public void DeleteCompetence(int Id)
        {
            _CompetenceDalRepository.DeleteCompetence(Id);
        }

        public IEnumerable<CompetenceBllModel> GetAllCompetence()
        {
            return _CompetenceDalRepository.GetAllCompetence().Select(c => c.CompetenceDalToCompetenceBll());
        }
    }
}
