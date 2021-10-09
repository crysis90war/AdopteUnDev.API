using AdopteUnDev.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.DAL.Interfaces
{
    public interface IDeveloppeurRepository
    {
        // Login
        DeveloppeurEntity LoginDev(string email, string password);
        // Register
        void RegisterDev(DeveloppeurEntity entity);
        // GetByCompetence
        public CompetenceEntity GetByCompetenceId(int Id);
        // set Compétence
        void SetCompetence(int Id, CompetenceEntity Competence);
    }
}
