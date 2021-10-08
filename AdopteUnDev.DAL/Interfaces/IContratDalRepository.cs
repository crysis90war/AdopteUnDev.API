using AdopteUnDev.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.DAL.Interfaces
{
    public interface IContratDalRepository
    {
        /*// GetByDebeloperId
        public DeveloppeurDalEntity GetByDevId(int Id);
        // GetByClientId
        public ClientDalEntity GetByClientId(int Id);*/
        // Delete 
        void DeleteContrat(int Id);
        // Aceppte
        void AcceptContrat(bool Accept, int Id);
        // Decline
        void DeclineContrat(bool Decline, int Id);
        // Add Contrat
        void AddContrat(ContratDalEntity contrat);
    }
}
