using AutoMapper;
using Morango.Application.Feature.CRUD.AgricultorEntity.DTOs;
using Morango.WebApi.Controllers.BaseControllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Morango.Application.Feature.CRUD.AgricultorEntity.AgricultorCase.GetAll;
using Morango.Application.Feature.CRUD.AgricultorEntity.AgricultorCase.GetById;

namespace Morango.WebApi.Controllers.Entities
{
    [Route("api/Morango/Agricultor")]
    [ApiController]
    public class AgricultorController : BaseGetController
        <GetAllAgricultorCommand,
        GetByIdAgricultorCommand,
        AgricultorResponseDTO>
    {
        public AgricultorController(IMediator mediator, IMapper mapper, ILogger<BaseController> logger) : base(mediator, mapper, logger)
        {
        }
    }
}