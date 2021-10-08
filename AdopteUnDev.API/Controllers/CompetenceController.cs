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
    public class CompetenceController : ControllerBase
    {
        private ICompetenceBllRepository _competenceService;

        public CompetenceController(ICompetenceBllRepository competenceService)
        {
            _competenceService = competenceService;
        }

        [HttpPost("AddCompetence")]
        public IActionResult Addcompetence(CompetenceForm contrat)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest("erreur validation");
            }
            _competenceService.AddCompetence(contrat.CompApiToCompBll());
            return Ok();
        }

        [HttpDelete("Deletecompetence")]
        public IActionResult DeleteCompetence(int id)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest("erreur validation");
            }
            _competenceService.DeleteCompetence(id);
            return Ok();
        }

        [HttpGet("GetAllCompetence")]
        public IActionResult GetAllCompetence()
        {
            return Ok(_competenceService.GetAllCompetence());
        }
    }
}
