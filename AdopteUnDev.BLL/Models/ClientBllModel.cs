using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.BLL.Entities
{
    public class ClientBllModel
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Compagny { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Pswd { get; set; }

        public ClientBllModel(int id, string lastName, string firstName, string compagny, string tel, string email)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            Compagny = compagny;
            Tel = tel;
            Email = email;
        }

        public ClientBllModel(string lastName, string firstName, string compagny, string tel, string email, string pswd)
        {
            LastName = lastName;
            FirstName = firstName;
            Compagny = compagny;
            Tel = tel;
            Email = email;
            Pswd = pswd;
        }
    }
}
