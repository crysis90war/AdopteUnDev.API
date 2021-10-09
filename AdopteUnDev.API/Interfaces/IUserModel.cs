using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdopteUnDev.API.Interfaces
{
    public interface IUserModel
    {
        int Id { get; }
        string LastName { get; }
        string FirstName { get; }
        string Email { get; }
        string Token { get; }
    }
}
