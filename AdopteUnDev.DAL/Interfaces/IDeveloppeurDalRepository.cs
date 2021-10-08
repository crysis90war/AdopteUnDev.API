using AdopteUnDev.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.DAL.Interfaces
{
    public interface IDeveloppeurDalRepository
    {
        // Login
        DeveloppeurDalEntity LoginDev(string email, string password);
        // Register
        void RegisterDev(DeveloppeurDalEntity entity);
        // GetByCompetence
        public CompetenceDalEntity GetByCompetenceId(int Id);
        // set Compétence
        void SetCompetence(int Id, CompetenceDalEntity Competence);
    }
}
