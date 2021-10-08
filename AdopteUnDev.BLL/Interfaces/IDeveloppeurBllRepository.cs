using AdopteUnDev.BLL.Entities;
using AdopteUnDev.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.BLL.Interfaces
{
    public interface IDeveloppeurBllRepository
    {
        // Login
        DeveloppeurBllModel LoginDev(string email, string password);
        // Register
        void RegisterDev(DeveloppeurBllModel entity);
        // GetByCompetence
        public DeveloppeurBllModel GetByCompetenceId(int Id);
        // set Compétence
        void SetCompetence(int Id, CompetenceBllModel Competence);
    }
}
