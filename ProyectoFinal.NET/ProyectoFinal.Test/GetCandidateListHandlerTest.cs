using AutoMapper;
using FluentValidation;
using Moq;
using ProyectoFinal.Application.Contracts;
using ProyectoFinal.Application.Handlers;
using ProyectoFinal.Application.Models;
using ProyectoFinal.Domain.Entities;
using ProyectoFinal.Domain.Interfaces;
using Xunit;

namespace ProyectoFinal.Test
{
    public class GetCandidateListHandlerTest
    {
        private readonly Mock<IMapper> _mapper;
        private readonly Mock<IValidator<GetCandidateListRequest>> _validator;
        private readonly Mock<ICandidateRepository> _candidateRepository;


        private GetCandidateListHandler handler;

        public GetCandidateListHandlerTest()
        {

            var candidateDto = new CandidateDto();
            var result = new FluentValidation.Results.ValidationResult();

            var candidateList = new List<Candidate>
            {
                new Candidate
                {
                    FirstName = "Joel",
                    LastName = "Chiaraviglio"
                }

            };

            var candidateDtoList = new CandidateDto
            {

                FirstName = "JoelDto",
                LastName = "ChiaraviglioDto"

            };

            _validator = new Mock<IValidator<GetCandidateListRequest>>();
            _validator.Setup(x => x.Validate(It.IsAny<GetCandidateListRequest>())).Returns(result);

            _mapper = new Mock<IMapper>();
            _mapper.Setup(m => m.Map<CandidateDto>(It.IsAny<Candidate>())).Returns(candidateDtoList);

            _candidateRepository = new Mock<ICandidateRepository>();
            _candidateRepository.Setup(x => x.GetList()).Returns(candidateList);


            handler = new GetCandidateListHandler(_candidateRepository.Object, _mapper.Object, _validator.Object);
        }



        [Fact]
        public async void CuandoObtengoUnRequestValido_RetornoUnResponseValido()
        {
            //arrange 

            //act

            var response = await handler.Handle(new GetCandidateListRequest(), CancellationToken.None);

            //assert
            Assert.NotNull(response);
            Assert.NotNull(response.CandidateList);
        }
    }
}