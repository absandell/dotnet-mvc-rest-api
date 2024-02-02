using AutoMapper;
using Commander.Dtos;
using Commander.Models;

namespace Commander.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            // Need to be explicit with data flow for each mapping
            
            // Source -> Target
            CreateMap<Command, CommandReadDto>();
            
            // Target -> Source
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();

        }
    }
}