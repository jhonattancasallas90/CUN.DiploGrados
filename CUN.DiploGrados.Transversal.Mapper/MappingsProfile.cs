using System;
using AutoMapper;
using CUN.DiploGrados.Domain.Entity;
using CUN.DiploGrados.Application.DTO;
using CUN.DiploGrados.Application.DTO.ResponseDTO;
using CUN.DiploGrados.Domain.Entity.Response;

namespace CUN.DiploGrados.Transversal.Mapper
{
    public class MappingsProfile : Profile
    {
        // Conexion entre el DTO y Entity o VSA(ReverseMap).
        public MappingsProfile()
        {
            CreateMap<MasterDTO, Master>().ReverseMap();
            CreateMap<PayloadDTO, Payload>().ReverseMap();
            CreateMap<PayloadResponseDTO, PayloadResponse>().ReverseMap();
            CreateMap<StudentDTO, Students>().ReverseMap();
            CreateMap<StudentsPayloadDTO, StudentsPayload>().ReverseMap();
            CreateMap<UsersDto, Users>().ReverseMap();
            CreateMap<DocumentJsonMetadataDTO, DocumentJsonMetadata>().ReverseMap();
            CreateMap<DocumentsDTO, Documents>().ReverseMap();
            CreateMap<PagesDTO, Pages>().ReverseMap();
            CreateMap<ParticipantFlowDTO, ParticipantFlow>().ReverseMap();


            //CreateMap<Customers, CustomersDto>().ReverseMap()
            //    .ForMember(destination => destination.CustomerId, source => source.MapFrom(src => src.CustomerId))
            //    .ForMember(destination => destination.CompanyName, source => source.MapFrom(src => src.CompanyName))
            //    .ForMember(destination => destination.ContactName, source => source.MapFrom(src => src.ContactName))
            //    .ForMember(destination => destination.ContactTitle, source => source.MapFrom(src => src.ContactTitle))
            //    .ForMember(destination => destination.Address, source => source.MapFrom(src => src.Address))
            //    .ForMember(destination => destination.City, source => source.MapFrom(src => src.City))
            //    .ForMember(destination => destination.Region, source => source.MapFrom(src => src.Region))
            //    .ForMember(destination => destination.PostalCode, source => source.MapFrom(src => src.PostalCode))
            //    .ForMember(destination => destination.Country, source => source.MapFrom(src => src.Country))
            //    .ForMember(destination => destination.Phone, source => source.MapFrom(src => src.Phone))
            //    .ForMember(destination => destination.Fax, source => source.MapFrom(src => src.Fax)).ReverseMap();
        }
    }
}
