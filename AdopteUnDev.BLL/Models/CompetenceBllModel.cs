using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.BLL.Models
{
    public class CompetenceBllModel
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public CompetenceBllModel(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }

        public CompetenceBllModel(string nom)
        {
            Nom = nom;
        }
    }
}
