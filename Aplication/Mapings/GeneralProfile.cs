
using Aplication.DTOs;
using Aplication.Feautres.Clientes.Commands.CreateClienteCommand;
using AutoMapper;
using Domain.Entities;


namespace Aplication.Mapings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            #region DTOs
            CreateMap<Cliente, ClienteDto>();
            #endregion

            #region Commands

            CreateMap<CreateClienteCommand, Cliente>();
            
            #endregion
        }
    }
}
