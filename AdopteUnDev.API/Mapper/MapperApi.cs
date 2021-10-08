using AdopteUnDev.API.Models;
using AdopteUnDev.BLL.Entities;
using AdopteUnDev.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdopteUnDev.API.Mapper
{
    public static class MapperApi
    {
        /*-----------------------------------------Client----------------------------------------------*/
        internal static ClientBllModel ClientApiToClientBll(this ClientForm Form)
        {
            return new ClientBllModel
                (
                 Form.LastName,
                 Form.FirstName,
                 Form.Compagny,
                 Form.Tel,
                 Form.Email,
                 Form.Pswd
                );
        }

        internal static ClientForm ClientBllToClientApi(this ClientBllModel Form)
        {
            return new ClientForm()
            {
                LastName = Form.LastName,
                FirstName = Form.FirstName,
                Compagny = Form.Compagny,
                Tel = Form.Tel,
                Email = Form.Email
            };
        }

        /*-----------------------------------------Contrat----------------------------------------------*/
        internal static ContratBllModel ContratApiToContratBll(this ContratForm entity)
        {
            return new ContratBllModel
                (

                    entity.Intituler,
                    entity.Duree,
                    entity.Description
                );

        }

        internal static ContratForm ContratBllToContratApi(this ContratBllModel entity)
        {
            return new ContratForm()
            {
                Intituler = entity.Intituler,
                Duree = entity.Duree,
                Description = entity.Description
            };

        }

        /*-----------------------------------------Developpeur---------------------------------------*/
        internal static DeveloppeurBllModel DevApiToDevBll(this DeveloppeurForm entity)
        {
            return new DeveloppeurBllModel
                (
                    entity.LastName,
                    entity.FirstName,
                    entity.BirthDate,
                    entity.Tel,
                    entity.Email
                );
        }

        internal static DeveloppeurForm DevBllToDevApi(this DeveloppeurBllModel entity)
        {
            return new DeveloppeurForm()
            {
                LastName = entity.LastName,
                FirstName = entity.FirstName,
                BirthDate = entity.BirthDate,
                Tel = entity.Tel,
                Email = entity.Email
            };


        }

        /*-----------------------------------------Competence-------------------------------------*/

        internal static CompetenceBllModel CompApiToCompBll(this CompetenceForm entity)
        {
            return new CompetenceBllModel
                (
                    entity.Nom
                );
        }

        internal static CompetenceForm CompBllToCompApi(this CompetenceBllModel entity)
        {
            return new CompetenceForm()
            {
                Nom = entity.Nom
            };
        }
    }
}
