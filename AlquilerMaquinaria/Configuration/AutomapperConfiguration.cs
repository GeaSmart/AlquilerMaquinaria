using AutoMapper;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.DTO;

namespace AlquilerMaquinaria.Configuration
{
    public static class AutomapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize( config =>
            {
                config.AddProfile<MappingProfile>();
            });
        }
    }

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CLIENTE, ListadoClienteDTO>()
                .ForMember(dest => dest.nombre_completo_razon_social, opt => opt.MapFrom(src => $"{src.nombres_razonsocial} { src.apellidos }"))
                .ForMember(dest => dest.tipo_documento, opt => opt.MapFrom(src =>  src.dni_ruc.Length>8?"RUC":"DNI" ))
                .ForMember(dest => dest.numero_documento, opt => opt.MapFrom(src => src.dni_ruc));
            CreateMap<ListadoClienteDTO, CLIENTE>()
                .ForMember(x => x.CONTRATOes, opt => opt.Ignore())
                .ForMember(x => x.ADJUNTOS, opt => opt.Ignore());

            //.ForMember(dest => dest.Edad, opt => opt.MapFrom(src => DateTime.Now.Year - src.FechaNacimiento.Year));
        }
    }
}
