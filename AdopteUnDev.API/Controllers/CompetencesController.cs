using AdopteUnDev.API.Mapper;
using AdopteUnDev.API.Models;
using AdopteUnDev.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdopteUnDev.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetencesController : ControllerBase
    {
        private ICompetenceService _competenceService;

        public CompetencesController(ICompetenceService competenceService)
        {
            _competenceService = competenceService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CompetenceModel>> GetCompetences()
        {
            IEnumerable<CompetenceModel> competences = _competenceService.GetAllCompetence().Select(x => x.BllToApi());
            return Ok(competences);
        }

        [HttpGet("{id}")]
        public ActionResult<CompetenceModel> GetCompetence(int id)
        {
            CompetenceModel competence = _competenceService.GetById(id).BllToApi();
            if (competence is null) return NotFound();
            return competence;
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCompetence(int id, CompetenceModel model)
        {
            if (id != model.Id) return BadRequest();
            CompetenceModel competence = _competenceService.GetById(id).BllToApi();
            if (competence is null) return NotFound();
            competence.Nom = model.Nom;
            try
            {
                _competenceService.Update(id, competence.ApiToBll());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return NoContent();
        }

        [HttpPost]
        public IActionResult CreateCompetence([FromBody] CompetenceModel model)
        {
            if (!ModelState.IsValid) return BadRequest("erreur validation");

            CompetenceModel competence = new()
            {
                Nom = model.Nom
            };

            _competenceService.Create(competence.ApiToBll());
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCompetence(int id)
        {
            CompetenceModel competence = _competenceService.GetById(id).BllToApi();
            if (competence is null) return NotFound();
            _competenceService.Delete(id);
            return NoContent();
        }

        //[HttpPost("AddCompetence")]
        //public IActionResult Addcompetence(CompetenceForm contrat)
        //{

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest("erreur validation");
        //    }
        //    _competenceService.AddCompetence(contrat.ApiToBll());
        //    return Ok();
        //}

        //[HttpDelete("Deletecompetence")]
        //public IActionResult DeleteCompetence(int id)
        //{

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest("erreur validation");
        //    }
        //    _competenceService.DeleteCompetence(id);
        //    return Ok();
        //}

        //[HttpGet("GetAllCompetence")]
        //public IActionResult GetAllCompetence()
        //{
        //    return Ok(_competenceService.GetAllCompetence());
        //}
    }
}
