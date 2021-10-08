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
        private IDeveloppeurBllRepository _developpeService;

        public DeveloppeurController(IDeveloppeurBllRepository developpeService)
        {
            _developpeService = developpeService;
        }

        [HttpPost("registerDev")]
        public IActionResult RegisterDev(DeveloppeurForm form)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _developpeService.RegisterDev(form.DevApiToDevBll());
            return Ok();
        }
    }
}
