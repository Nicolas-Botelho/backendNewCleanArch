using AutoMapper;
using Morango.Application.DTOs.Entities.Response;
using Morango.Application.UseCase.Entities.AgricultorCase.GetAll;
using Morango.Application.UseCase.Entities.AgricultorCase.GetById;
using Morango.WebApi.Controllers.BaseControllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Morango.WebApi.Controllers.Entities
{
    [Route("api/Agricultor")]
    [ApiController]
    public class AgricultorController : BaseGetController
        <GetAllAgricultorCommand,
        GetByIdAgricultorCommand,
        AgricultorResponseDTO>
    {
        public AgricultorController(IMediator mediator, IMapper mapper) : base(mediator, mapper)
        {
        }
    }
}