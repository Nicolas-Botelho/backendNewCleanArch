using AutoMapper;
using ConectaFapes.Common.Utils.Responses;
using Morango.Application.Feature.CRUD.AgricultorEntity.AgricultorCase.GetById;
using Morango.Application.Feature.CRUD.AgricultorEntity.DTOs;
using Morango.Domain.Entities;

namespace Morango.Application.Mappers.Entities
{
  public class AgricultorMapper : Profile
  {
      public AgricultorMapper()
      {
          #region Entidade para DTO's
          CreateMap<Agricultor, AgricultorResponseDTO>().ReverseMap();
          CreateMap<Agricultor, AgricultorRequestDTO>().ReverseMap();

          #endregion

          #region Entidade para Commads de Caso de Uso
          CreateMap<Agricultor, GetByIdAgricultorCommand>().ReverseMap();
          #endregion

          #region DTO's para Commads de Caso de Uso

          #endregion

          #region Conversão para api response
          CreateMap<ApiResponse, AgricultorRequestDTO>().ReverseMap();
          #endregion
      }
  }
}