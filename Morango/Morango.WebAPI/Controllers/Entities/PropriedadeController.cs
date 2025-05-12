using AutoMapper;
using Morango.WebApi.Controllers.BaseControllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Morango.Application.Feature.CRUD.Propriedade.PropriedadePropriedadeCase.CreatePropriedade;
using Morango.Application.Feature.CRUD.Propriedade.PropriedadePropriedadeCase.DeletePropriedade;
using Morango.Application.Feature.CRUD.Propriedade.PropriedadePropriedadeCase.GetAllPropriedade;
using Morango.Application.Feature.CRUD.Propriedade.PropriedadePropriedadeCase.GetByIdPropriedade;
using Morango.Application.Feature.CRUD.Propriedade.PropriedadePropriedadeCase.UpdatePropriedade;
using Morango.Application.Feature.CRUD.Propriedade.DTOs;

namespace Morango.WebApi.Controllers.Entities
{
    [Route("api/Propriedade")]
    [ApiController]
    public class PropriedadeController : BaseCRUDController
        <GetAllPropriedadeCommand,
        GetByIdPropriedadeCommand,
        CreatePropriedadeCommand,
        UpdatePropriedadeCommand,
        DeletePropriedadeCommand,
        PropriedadeResponseDTO>
    {
        public PropriedadeController(IMediator mediator, IMapper mapper) : base(mediator, mapper)
        {
        }
    }
}