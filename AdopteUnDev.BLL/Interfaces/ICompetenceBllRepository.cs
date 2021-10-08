using AdopteUnDev.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.BLL.Interfaces
{
    public interface ICompetenceBllRepository
    {
        // Add
        void AddCompetence(CompetenceBllModel Competence);
        // Delete
        void DeleteCompetence(int Id);
        // GetAll
        IEnumerable<CompetenceBllModel> GetAllCompetence();
    }
}
