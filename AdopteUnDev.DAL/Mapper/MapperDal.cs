using AdopteUnDev.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.DAL.Mapper
{
    internal static class MapperDal
    {
        internal static ClientDalEntity DBToDALClientEntity(this IDataRecord dataRecord)
        {
            return new ClientDalEntity
                (
                    (int)dataRecord["Id"],
                    (string)dataRecord["LastName"],
                    (string)dataRecord["FirstName"],
                    (string)dataRecord["Compagny"],
                    (string)dataRecord["Tel"],
                    (string)dataRecord["Email"]
                );

        }

        internal static CompetenceDalEntity DBToDALCompEntity(this IDataRecord dataRecord)
        {
            return new CompetenceDalEntity
                (
                    (int)dataRecord["Id"],
                    (string)dataRecord["Nom"]
                );

        }

        internal static ContratDalEntity DBToDALContratEntity(this IDataRecord dataRecord)
        {
            return new ContratDalEntity
                (
                    (int)dataRecord["Id"],
                    (string)dataRecord["Intituler"],
                    (int)dataRecord["Duree"],
                    (bool)dataRecord["Statut"],
                    (string)dataRecord["Description"]
                );
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

        internal static DeveloppeurDalEntity DBToDALDevEntity(this IDataRecord dataRecord)
        {
            return new DeveloppeurDalEntity
                (
                    (int)dataRecord["Id"],
                    (string)dataRecord["LastName"],
                    (string)dataRecord["FirstName"],
                    (DateTime)dataRecord["BirthDate"],
                    (string)dataRecord["Tel"],
                    (string)dataRecord["Email"]
                );
        }
    }
}
