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
    public class ContratController : ControllerBase
    {
        private IContratBllRepository _contratService;

        public ContratController(IContratBllRepository contratService)
        {
            _contratService = contratService;
        }

        [HttpPost("AcceptContrat")]
        public IActionResult AcceptContrat(bool accept, int id)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest("erreur validation");
            }
            _contratService.AcceptContrat(accept, id);
            return Ok();
        }

        [HttpPost("DeclineContrat")]
        public IActionResult DeclineContrat(bool accept, int id)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest("erreur validation");
            }
            _contratService.DeclineContrat(accept, id);
            return Ok();
        }

        [HttpPost("AddContrat")]
        public IActionResult AddContrat(ContratForm contrat)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest("erreur validation");
            }
            _contratService.AddContrat(contrat.ContratApiToContratBll());
            return Ok();
        }

        [HttpDelete("DeleteContrat")]
        public IActionResult DeleteContrat(int id)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest("erreur validation");
            }
            _contratService.DeleteContrat(id);
            return Ok();
        }
    }
}
