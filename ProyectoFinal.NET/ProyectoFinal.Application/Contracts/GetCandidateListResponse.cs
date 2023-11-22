
using ProyectoFinal.Application.Models;
using ProyectoFinal.Domain.Entities;

namespace ProyectoFinal.Application.Contracts
{
    public class GetCandidateListResponse
    {
        public List<CandidateDto>? CandidateList { get; set; }
    }
}
