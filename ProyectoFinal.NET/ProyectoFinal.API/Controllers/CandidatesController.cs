using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Application.Contracts;
using ProyectoFinal.Domain.Interfaces;

namespace ProyectoFinal.API.Controllers
{
    [Route("/api/candidates")]
    public class CandidatesController : Controller
    {
        private readonly IMediator _mediator;


        public CandidatesController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetList([FromQuery] GetCandidateListRequest request)
        {
            var response = await _mediator.Send(request);

            return Ok(response);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            return Ok();
        }
    }
}
