using AutoMapper;
using Morango.Application.DTOs.Entities.Request;
using Morango.Application.DTOs.Entities.Response;
using Morango.Application.DTOs.Common;
using Morango.Application.UseCase.Entities.AgricultorCase.GetById;
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