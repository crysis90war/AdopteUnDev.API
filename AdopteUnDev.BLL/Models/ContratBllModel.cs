using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.BLL.Models
{
    public class ContratBllModel
    {
        public int Id { get; set; }
        public string Intituler { get; set; }
        public int Duree { get; set; }
        public bool Statut { get; set; }
        public string Description { get; set; }

        public ContratBllModel(int id, string intituler, int duree, bool statut, string description)
        {
            Id = id;
            Intituler = intituler;
            Duree = duree;
            Statut = statut;
            Description = description;
        }

        public ContratBllModel(string intituler, int duree, string description)
        {
            Intituler = intituler;
            Duree = duree;
            Description = description;
        }
    }
}
