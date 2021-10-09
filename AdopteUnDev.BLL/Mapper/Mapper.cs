using AdopteUnDev.BLL.Entities;
using AdopteUnDev.BLL.Models;
using AdopteUnDev.DAL.Entities;
using Tools.Mappers;

namespace AdopteUnDev.BLL.Mapper
{
    public static class Mapper
    {
        /* ----------------------------------------- Client ---------------------------------------------- */

        internal static ClientEntity BllToDal(this ClientBllModel entity)
        {
            return new ClientEntity()
            {
                Id = entity.Id,
                LastName = entity.LastName,
                FirstName = entity.FirstName,
                Compagny = entity.Compagny,
                Tel = entity.Tel,
                Email = entity.Email,
                Pswd = entity.Pswd
            };
        }

        internal static ClientBllModel DalToBll(this ClientEntity entity)
        {
            return new ClientBllModel
            {
                Id = entity.Id,
                LastName = entity.LastName,
                FirstName = entity.FirstName,
                Compagny = entity.Compagny,
                Tel = entity.Tel,
                Email = entity.Email
            };
        }

        /* ----------------------------------------- Developpeur ----------------------------------------- */

        internal static DeveloppeurEntity BllToDal(this DeveloppeurBllModel entity)
        {
            return new DeveloppeurEntity()
            {
                Id = entity.Id,
                LastName = entity.LastName,
                FirstName = entity.FirstName,
                BirthDate = entity.BirthDate,
                Tel = entity.Tel,
                Email = entity.Email
            };
        }

        internal static DeveloppeurBllModel DalToBll(this DeveloppeurEntity entity)
        {
            return new DeveloppeurBllModel()
            {
                Id = entity.Id,
                LastName = entity.LastName,
                FirstName = entity.FirstName,
                BirthDate = entity.BirthDate,
                Tel = entity.Tel,
                Email = entity.Email
            };
        }

        /* ----------------------------------------- Contrat ---------------------------------------------- */

        internal static ContratEntity BllToDal(this ContratBllModel entity) => MapperExtension.Map<ContratEntity>(entity);

        internal static ContratBllModel DalToBll(this ContratEntity entity) => MapperExtension.Map<ContratBllModel>(entity);

        /* ----------------------------------------- Competence ---------------------------------------------- */

        internal static CompetenceEntity BllToDal(this CompetenceBllModel entity) => MapperExtension.Map<CompetenceEntity>(entity);

        internal static CompetenceBllModel DalToBll(this CompetenceEntity entity) => MapperExtension.Map<CompetenceBllModel>(entity);
    }
}
