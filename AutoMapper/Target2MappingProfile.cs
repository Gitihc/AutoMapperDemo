using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoMapper
{
    class Target2MappingProfile:Profile
    {
        public override string ProfileName
        {
            get
            {
                return GetType().Name;
            }
        }
        protected override void Configure()
        {
            Mapper.CreateMap<Source, Target2>()
               .ForMember(dest => dest.age, opt => opt.MapFrom(src => src.id))
               .ForMember(dest => dest.className, opt => opt.UseValue("This is ClassName")); 
        }
    }
}
