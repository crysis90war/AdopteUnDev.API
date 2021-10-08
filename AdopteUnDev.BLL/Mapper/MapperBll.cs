using AdopteUnDev.BLL.Entities;
using AdopteUnDev.BLL.Models;
using AdopteUnDev.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.BLL.Mapper
{
    internal static class MapperBll
    {
        /*-----------------------------------------Client----------------------------------------------*/
        internal static ClientDalEntity ClientBllToClientDal(this ClientBllModel entity)
        {
            return new ClientDalEntity
                (
                    entity.Id,
                    entity.LastName,
                    entity.FirstName,
                    entity.Compagny,
                    entity.Tel,
                    entity.Email
                );
                
        }

        internal static ClientBllModel ClientDalToClientBll(this ClientDalEntity entity)
        {
            return new ClientBllModel
                (
                    entity.Id,
                    entity.LastName,
                    entity.FirstName, 
                    entity.Compagny, 
                    entity.Tel,
                    entity.Email
                );
        }

        /*-----------------------------------------Developpeur-----------------------------------------*/
        internal static DeveloppeurDalEntity DevBllToDevDal(this DeveloppeurBllModel entity)
        {
            return new DeveloppeurDalEntity
                (
                    entity.LastName,
                    entity.FirstName,
                    entity.BirthDate,
                    entity.Tel,
                    entity.Email
                );
        }

        internal static DeveloppeurBllModel DevDalToDevBll(this DeveloppeurDalEntity entity)
        {
            return new DeveloppeurBllModel
                (
                    entity.Id,
                    entity.LastName,
                    entity.FirstName,
                    entity.BirthDate,
                    entity.Tel,
                    entity.Email
                );

        }
        /*-----------------------------------------Contrat----------------------------------------------*/
        internal static ContratDalEntity ContratBllToContrattDal(this ContratBllModel entity)
        {
            return new ContratDalEntity
                (
                    
                    entity.Intituler,
                    entity.Duree,
                    entity.Statut,
                    entity.Description
                );

        }

        internal static ContratBllModel ContratDalToContratBll(this ContratDalEntity entity)
        {
            return new ContratBllModel
                (
                    entity.Id,
                    entity.Intituler,
                    entity.Duree,
                    entity.Statut,
                    entity.Description
                );
        }
        /*-----------------------------------------Competence----------------------------------------------*/
        internal static CompetenceDalEntity CompetenceBllToCompetenceDal(this CompetenceBllModel entity)
        {
            return new CompetenceDalEntity
                (
                    entity.Nom
                );

        }

        internal static CompetenceBllModel CompetenceDalToCompetenceBll(this CompetenceDalEntity entity)
        {
            return new CompetenceBllModel
                (
                    entity.Id,
                    entity.Nom
                );

        }
    }
}
