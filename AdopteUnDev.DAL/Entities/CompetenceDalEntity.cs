using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.DAL.Entities
{
    public class CompetenceDalEntity
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public CompetenceDalEntity(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }

        public CompetenceDalEntity(string nom)
        {
            Nom = nom;
        }
    }
}
