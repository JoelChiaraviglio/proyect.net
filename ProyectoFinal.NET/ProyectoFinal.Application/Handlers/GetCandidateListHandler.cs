
using AutoMapper;
using FluentValidation;
using MediatR;
using ProyectoFinal.Application.Contracts;
using ProyectoFinal.Application.Models;
using ProyectoFinal.Domain.Entities;
using ProyectoFinal.Domain.Interfaces;

namespace ProyectoFinal.Application.Handlers
{
    public class GetCandidateListHandler : IRequestHandler<GetCandidateListRequest, GetCandidateListResponse>
    {
        private readonly IMapper _mapper;
        private readonly IValidator<GetCandidateListRequest> _validator;
        private readonly ICandidateRepository _candidateRepository;

        public GetCandidateListHandler(ICandidateRepository candidateRepository, IMapper mapper, IValidator<GetCandidateListRequest> validator )
        {
            _candidateRepository = candidateRepository;
            _mapper = mapper;
            _validator = validator;
        }

        public async Task<GetCandidateListResponse> Handle(GetCandidateListRequest request, CancellationToken cancellationToken)
        {
            var response = new GetCandidateListResponse();

            var result = _validator.Validate(request);

            if (!result.IsValid)
                throw new Exception();

            var candidateList = _candidateRepository.GetList();

            response.CandidateList = candidateList.Select(x => MapTo(x)).ToList();

            return response;
        }

        private CandidateDto MapTo(Candidate candidate)
        {
            return _mapper.Map<CandidateDto>(candidate);
        }
    }
}
