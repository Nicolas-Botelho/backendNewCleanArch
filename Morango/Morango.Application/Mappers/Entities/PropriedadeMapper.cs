using AutoMapper;
using Morango.Domain.Entities;
using Morango.Application.Feature.CRUD.PropriedadeEntity.PropriedadeCase.Create;
using Morango.Application.Feature.CRUD.PropriedadeEntity.PropriedadeCase.Delete;
using Morango.Application.Feature.CRUD.PropriedadeEntity.PropriedadeCase.GetById;
using Morango.Application.Feature.CRUD.PropriedadeEntity.PropriedadeCase.Update;
using Morango.Application.Feature.CRUD.PropriedadeEntity.DTOs;
using ConectaFapes.Common.Utils.Responses;

namespace Morango.Application.Mappers.Entities
{
    public class PropriedadeMapper : Profile
    {
        public PropriedadeMapper()
        {
            #region Entidade para DTO's
            CreateMap<Propriedade, PropriedadeResponseDTO>().ReverseMap();
            CreateMap<Propriedade, PropriedadeRequestDTO>().ReverseMap();

            #endregion

            #region Entidade para Commads de Caso de Uso
            CreateMap<Propriedade, CreatePropriedadeCommand>().ReverseMap();
            CreateMap<Propriedade, UpdatePropriedadeCommand>().ReverseMap();
            CreateMap<Propriedade, GetByIdPropriedadeCommand>().ReverseMap();
            CreateMap<Propriedade, DeletePropriedadeCommand>().ReverseMap();
            #endregion

            #region DTO's para Commads de Caso de Uso
            CreateMap<PropriedadeRequestDTO, CreatePropriedadeCommand>().ReverseMap() ;
            CreateMap<PropriedadeRequestDTO, UpdatePropriedadeCommand>().ReverseMap() ;
            CreateMap<PropriedadeRequestDTO, DeletePropriedadeCommand>().ReverseMap();
            #endregion

            #region Conversão para api response
            CreateMap<ApiResponse, PropriedadeRequestDTO>().ReverseMap();
            CreateMap<ApiResponse, CreatePropriedadeCommand>().ReverseMap();
            CreateMap<ApiResponse, UpdatePropriedadeCommand>().ReverseMap();
            CreateMap<ApiResponse, DeletePropriedadeCommand>().ReverseMap();
            #endregion
        }
    }
}