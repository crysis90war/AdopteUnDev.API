using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.DAL.Entities
{
    public class ClientDalEntity
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Compagny { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Pswd { get; set; }

        public ClientDalEntity(int id, string lastName, string firstName, string compagny, string tel, string email)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            Compagny = compagny;
            Tel = tel;
            Email = email;
        }
    }
}
