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
            CreateMap<Master, MasterDTO>().ReverseMap();
            CreateMap<Payload, PayloadDTO>().ReverseMap();
            CreateMap<PayloadResponse, PayloadResponseDTO>().ReverseMap();
            CreateMap<Students, StudentDTO>().ReverseMap();
            CreateMap<StudentsPayload, StudentsPayloadDTO>().ReverseMap();              // POR REVISAR FUNCIONALIDAD DE MAPEO, SI NO ES NECESARIO, ELIMINAR
            CreateMap<Users, UsersDto>().ReverseMap();

            CreateMap<DocumentJsonMetadata, DocumentJsonMetadataDTO>().ReverseMap();
            CreateMap<Documents, DocumentsDTO>().ReverseMap();
            CreateMap<Pages, PagesDTO>().ReverseMap();
            CreateMap<ParticipantFlow, ParticipantFlowDTO>().ReverseMap();

            CreateMap<StudentsGradeInfo, StudentsGradesDTO>().ReverseMap();
            CreateMap<StudentGradePayload, StudentGradePayloadDTO>().ReverseMap();

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
