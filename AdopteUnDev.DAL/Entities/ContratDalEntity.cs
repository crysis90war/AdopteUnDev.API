using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.DAL.Entities
{
    public class ContratDalEntity
    {
        public int Id { get; set; }
        public string Intituler { get; set; }
        public int Duree { get; set; }
        public bool Statut { get; set; }
        public string Description { get; set; }

        public ContratDalEntity(string intituler, int duree, bool statut, string description)
        {
            Intituler = intituler;
            Duree = duree;
            Statut = statut;
            Description = description;
        }

        public ContratDalEntity(int id, string intituler, int duree, bool statut, string description)
        {
            Id = id;
            Intituler = intituler;
            Duree = duree;
            Statut = statut;
            Description = description;
        }
    }
}
