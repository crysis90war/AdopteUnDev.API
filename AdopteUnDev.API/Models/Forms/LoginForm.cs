using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdopteUnDev.API.Models.Forms
{
    public class LoginForm
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Pswd { get; set; }
    }
}
