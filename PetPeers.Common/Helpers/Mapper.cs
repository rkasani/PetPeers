using AutoMapper;
using PetPeers.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPeers.Common.Helpers
{
    public class Mapper<TSource, TDestination>
    {
        public static IEnumerable<TDestination> TransformDTO(IEnumerable<TSource> model)
        {
            var config = GetMapperConfiguration();

            IMapper mapper = config.CreateMapper();
            return mapper.Map<IEnumerable<TSource>, IEnumerable<TDestination>>(model);
        }

        private static MapperConfiguration GetMapperConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Domain.DTO.PetDTO, Pet>()
                .ForMember(petDTO => petDTO.PetId, v => v.MapFrom(pet => pet.PetId))
                .ForMember(petDTO => petDTO.PetName, v => v.MapFrom(pet => pet.PetName))
                .ForMember(petDTO => petDTO.Age, v => v.MapFrom(pet => pet.Age))
                .ForMember(petDTO => petDTO.Place, v => v.MapFrom(pet => pet.Place))
                .ForMember(petDTO => petDTO.IsAvailable, v => v.MapFrom(pet => pet.IsSold));

                cfg.CreateMap<Pet, Domain.DTO.PetDTO>()
                 .ForMember(pet => pet.PetId, v => v.MapFrom(petDto => petDto.PetId))
                .ForMember(pet => pet.PetName, v => v.MapFrom(petDto => petDto.PetName))
                .ForMember(pet => pet.Age, v => v.MapFrom(petDto => petDto.Age))
                .ForMember(pet => pet.Place, v => v.MapFrom(petDto => petDto.Place))
                .ForMember(pet => pet.IsSold, v => v.MapFrom(petDto => petDto.IsAvailable));

                
            });
            return config;
        }
    }
}
