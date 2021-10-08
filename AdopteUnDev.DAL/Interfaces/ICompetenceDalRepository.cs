using AdopteUnDev.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.DAL.Interfaces
{
    public interface ICompetenceDalRepository
    {
        // ADD
        void AddCompetence(CompetenceDalEntity Competence);
        // Delete
        void DeleteCompetence(int Id);
        // Get
        IEnumerable<CompetenceDalEntity> GetAllCompetence();
    }
}
