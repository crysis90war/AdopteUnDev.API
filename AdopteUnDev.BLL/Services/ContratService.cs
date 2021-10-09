using AdopteUnDev.BLL.Interfaces;
using AdopteUnDev.BLL.Mapper;
using AdopteUnDev.BLL.Models;
using AdopteUnDev.DAL.Entities;
using AdopteUnDev.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.BLL.Services
{
    public class ContratService : IContratService
    {
        private readonly IContratRepository _contratDalRepository;
        public ContratService(IContratRepository contratDalRepository)
        {
            _contratDalRepository = contratDalRepository;
        }

        public void AcceptContrat(bool Accept, int Id)
        {
            _contratDalRepository.AcceptContrat(Accept,Id);
        }
        public void DeclineContrat(bool Decline, int Id)
        {
            _contratDalRepository.DeclineContrat(Decline, Id);
        }

        public void AddContrat(ContratBllModel contrat)
        {
            _contratDalRepository.AddContrat(contrat.BllToDal());
        }

        public void DeleteContrat(int Id)
        {
            _contratDalRepository.DeleteContrat(Id);
        }
    }
}
