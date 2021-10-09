using AdopteUnDev.API.Models;
using AdopteUnDev.BLL.Entities;
using AdopteUnDev.BLL.Models;
using Tools.Mappers;

namespace AdopteUnDev.API.Mapper
{
    public static class Mapper
    {
        /* ----------------------------------------- Client ---------------------------------------------- */

        internal static ClientBllModel ApiToBll(this ClientRegisterForm Form)
        {
            return new ClientBllModel()
            {
                LastName = Form.LastName,
                FirstName = Form.FirstName,
                Compagny = Form.Compagny,
                Tel = Form.Tel,
                Email = Form.Email,
                Pswd = Form.Pswd
            };
        }

        internal static ClientRegisterForm BllToApi(this ClientBllModel Form)
        {
            return new ClientRegisterForm()
            {
                LastName = Form.LastName,
                FirstName = Form.FirstName,
                Compagny = Form.Compagny,
                Tel = Form.Tel,
                Email = Form.Email
            };
        }

        /* ----------------------------------------- Developpeur --------------------------------------- */

        internal static DeveloppeurBllModel ApiToBll(this DeveloppeurForm entity)
        {
            return new DeveloppeurBllModel()
            {
                LastName = entity.LastName,
                FirstName = entity.FirstName,
                BirthDate = entity.BirthDate,
                Tel = entity.Tel,
                Email = entity.Email,
            };
        }

        internal static DeveloppeurForm BllToApi(this DeveloppeurBllModel entity)
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

        /* ----------------------------------------- Contrat ---------------------------------------------- */

        internal static ContratBllModel ApiToBll(this ContratForm entity) => MapperExtension.Map<ContratBllModel>(entity);

        internal static ContratForm BllToApi(this ContratBllModel entity) => MapperExtension.Map<ContratForm>(entity);

        /* ----------------------------------------- Competence ------------------------------------- */

        internal static CompetenceBllModel ApiToBll(this CompetenceForm entity) => MapperExtension.Map<CompetenceBllModel>(entity);
        internal static CompetenceBllModel ApiToBll(this CompetenceModel moddel) => MapperExtension.Map<CompetenceBllModel>(moddel);

        internal static CompetenceModel BllToApi(this CompetenceBllModel entity) => MapperExtension.Map<CompetenceModel>(entity);
    }
}
