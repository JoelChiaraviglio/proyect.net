using AutoMapper;
using ProyectoFinal.Application.Models;
using ProyectoFinal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Application.Profiles
{
    public class CandidateProfile : Profile
    {
        public CandidateProfile() 
        {
            CreateMap<Candidate, CandidateDto>();
        }
    }
}
