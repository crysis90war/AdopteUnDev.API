using AdopteUnDev.API.Infrastructure;
using AdopteUnDev.API.Mapper;
using AdopteUnDev.API.Models;
using AdopteUnDev.API.Models.Forms;
using AdopteUnDev.BLL.Entities;
using AdopteUnDev.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdopteUnDev.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private IClientBllRepository _ClientService;
        private readonly TokenManager _tokenManager;

        public ClientController(IClientBllRepository userService, TokenManager tokenManager)
        {
            _ClientService = userService;
            _tokenManager = tokenManager;
        }

        [HttpPost("loginClient")]
        public IActionResult LoginClient(LoginForm form)
        {

            ClientBllModel currentUser = _ClientService.LoginClient(form.Email, form.Pswd);
            if (currentUser is null)
            {
                return BadRequest("Utilisateur null");
            }
            ClientModel client = new ClientModel()
            {
                Id = currentUser.Id,
                LastName = currentUser.LastName,
                FirstName = currentUser.FirstName,
                Email  = currentUser.Email
            };
            client.Token = _tokenManager.GenerateJWT(client);
            return Ok(client);
        }

        [HttpPost("registerClient")]
        public IActionResult RegisterClient(ClientForm form)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _ClientService.RegisterClient(form.ClientApiToClientBll());
            return Ok();
        }
    }
}
