using AdopteUnDev.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.DAL.Interfaces
{
    public interface ICompetenceRepository : IRepositoryBase<CompetenceEntity, int>
    {
        // ADD
        void AddCompetence(CompetenceEntity Competence);
        // Delete
        void DeleteCompetence(int Id);
        // Get
        IEnumerable<CompetenceEntity> GetAllCompetence();
    }
}
