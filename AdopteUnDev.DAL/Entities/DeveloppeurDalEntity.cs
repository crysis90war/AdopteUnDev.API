using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.DAL.Entities
{
    public class DeveloppeurDalEntity
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Pswd { get; set; }

        public DeveloppeurDalEntity(int id, string lastName, string firstName, DateTime birthDate, string tel, string email)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            BirthDate = birthDate;
            Tel = tel;
            Email = email;
        }

        public DeveloppeurDalEntity(string lastName, string firstName, DateTime birthDate, string tel, string email)
        {
            LastName = lastName;
            FirstName = firstName;
            BirthDate = birthDate;
            Tel = tel;
            Email = email;
        }
    }
}
