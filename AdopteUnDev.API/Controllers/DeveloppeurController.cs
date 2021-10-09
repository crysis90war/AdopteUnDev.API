using AdopteUnDev.API.Infrastructure;
using AdopteUnDev.API.Mapper;
using AdopteUnDev.API.Models;
using AdopteUnDev.BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdopteUnDev.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloppeurController : ControllerBase
    {
        private IDeveloppeurService _developpeService;
        private readonly TokenManager _tokenManager;

        public DeveloppeurController(IDeveloppeurService developpeService, TokenManager tokenManager)
        {
            _developpeService = developpeService;
            _tokenManager = tokenManager;
        }

        [HttpPost(nameof(Register))]
        public IActionResult Register(DeveloppeurForm form)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _developpeService.RegisterDev(form.ApiToBll());
            return Ok();
        }

        [HttpPost(nameof(Login))]
        public IActionResult Login()
        {
            return Ok();
        }
    }
}
