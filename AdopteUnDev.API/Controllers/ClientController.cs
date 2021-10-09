using AdopteUnDev.API.Infrastructure;
using AdopteUnDev.API.Mapper;
using AdopteUnDev.API.Models;
using AdopteUnDev.API.Models.Forms;
using AdopteUnDev.BLL.Entities;
using AdopteUnDev.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AdopteUnDev.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private IClientService _ClientService;
        private readonly TokenManager _tokenManager;

        public ClientController(IClientService userService, TokenManager tokenManager)
        {
            _ClientService = userService;
            _tokenManager = tokenManager;
        }

        [HttpPost(nameof(Login))]
        public IActionResult Login(LoginForm form)
        {

            ClientBllModel currentUser = _ClientService.LoginClient(form.Email, form.Pswd);
            if (currentUser is null) return BadRequest("Utilisateur null");

            ClientModel client = new ClientModel()
            {
                Id = currentUser.Id,
                LastName = currentUser.LastName,
                FirstName = currentUser.FirstName,
                Email = currentUser.Email
            };

            client.Token = _tokenManager.GenerateJWT(client);
            return Ok(client);
        }

        [HttpPost(nameof(Register))]
        public IActionResult Register(ClientRegisterForm form)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _ClientService.RegisterClient(form.ApiToBll());
            return Ok();
        }
    }
}
