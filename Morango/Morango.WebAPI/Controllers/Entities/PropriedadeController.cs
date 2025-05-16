using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Morango.Application.Feature.CRUD.PropriedadeEntity.PropriedadeCase.Create;
using Morango.Application.Feature.CRUD.PropriedadeEntity.PropriedadeCase.Delete;
using Morango.Application.Feature.CRUD.PropriedadeEntity.PropriedadeCase.GetAll;
using Morango.Application.Feature.CRUD.PropriedadeEntity.PropriedadeCase.GetById;
using Morango.Application.Feature.CRUD.PropriedadeEntity.PropriedadeCase.Update;
using Morango.Application.Feature.CRUD.PropriedadeEntity.DTOs;
using Morango.WebApi.Controllers.BaseControllers;

namespace Morango.WebApi.Controllers.Entities
{
    [Route("api/Morango/Propriedade")]
    [ApiController]
    public class PropriedadeController : BaseCrudController
        <GetAllPropriedadeCommand,
        GetByIdPropriedadeCommand,
        CreatePropriedadeCommand,
        UpdatePropriedadeCommand,
        DeletePropriedadeCommand,
        PropriedadeResponseDTO>
    {
        public PropriedadeController(IMediator mediator, IMapper mapper, ILogger<BaseController> logger) : base(mediator, mapper, logger)
        {
        }
    }
}