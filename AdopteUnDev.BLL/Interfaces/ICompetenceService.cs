using AdopteUnDev.BLL.Models;
using AdopteUnDev.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.BLL.Interfaces
{
    public interface ICompetenceService : IRepositoryBase<CompetenceBllModel, int>
    {
        // ADD
        void AddCompetence(CompetenceBllModel model);
        // Delete
        void DeleteCompetence(int Id);
        // Get
        IEnumerable<CompetenceBllModel> GetAllCompetence();
    }
}
