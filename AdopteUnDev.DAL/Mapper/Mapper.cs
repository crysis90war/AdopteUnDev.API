using AdopteUnDev.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.DAL.Mapper
{
    internal static class Mapper
    {
        internal static ClientEntity DbToClient(this IDataRecord dataRecord)
        {
            return new ClientEntity()
            {
                Id = (int)dataRecord["Id"],
                LastName = (string)dataRecord["LastName"],
                FirstName = (string)dataRecord["FirstName"],
                Compagny = (string)dataRecord["Compagny"],
                Tel = (string)dataRecord["Tel"],
                Email = (string)dataRecord["Email"]
            };
        }

        internal static DeveloppeurEntity DbToDeveloppeur(this IDataRecord dataRecord)
        {
            return new DeveloppeurEntity()
            {
                Id = (int)dataRecord["Id"],
                LastName = (string)dataRecord["LastName"],
                FirstName = (string)dataRecord["FirstName"],
                BirthDate = (DateTime)dataRecord["BirthDate"],
                Tel = (string)dataRecord["Tel"],
                Email = (string)dataRecord["Email"]
            };
        }

        internal static CompetenceEntity DbToCompetence(this IDataRecord record)
        {
            return new CompetenceEntity()
            {
                Id = (int)record["Id"],
                Nom = (string)record["Nom"]
            };
        }

        internal static ContratEntity DbToContrat(this IDataRecord dataRecord)
        {
            return new ContratEntity()
            {
                Id = (int)dataRecord["Id"],
                Intituler = (string)dataRecord["Intituler"],
                Duree = (int)dataRecord["Duree"],
                Statut = (bool)dataRecord["Statut"],
                Description = (string)dataRecord["Description"]
            };
        }

        // mapping pour la table mtm DevCom

        /*internal static DevComEntity DBToDALDevComEntity(this IDataRecord dataRecord)
        {
            return new DevComEntity()
            {
                DeveloppeurId = (int)dataRecord["DeveloppeurId"],
                CompetenceId = (int)dataRecord["CompetenceId"]
            };
        }*/
    }
}
