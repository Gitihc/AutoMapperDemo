using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cgf =>{
                Mapper.AddProfile<Target2MappingProfile>();
            });
            Mapper.AssertConfigurationIsValid();
        }
    }
}
