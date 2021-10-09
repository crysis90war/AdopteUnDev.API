using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.DAL.Entities
{
    public class ContratEntity
    {
        public int Id { get; set; }
        public string Intituler { get; set; }
        public int Duree { get; set; }
        public bool Statut { get; set; }
        public string Description { get; set; }
    }
}
