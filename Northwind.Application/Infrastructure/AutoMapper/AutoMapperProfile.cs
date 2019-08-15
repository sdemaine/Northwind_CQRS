using AutoMapper;
using System;
using System.Reflection;
using Northwind.Application;
using System.Linq;

namespace Northwind.Application.Infrastructure.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            LoadStandardMappings();
            LoadCustomMappings();
            LoadConverters();
        }

        private void LoadConverters()
        {

        }

        private void LoadStandardMappings()
        {
            var mapsFrom = MapperProfileHelper.LoadStandardMappings(Assembly.GetExecutingAssembly());

            foreach (var map in mapsFrom)
            {
                CreateMap(map.Source, map.Destination).ReverseMap();
            }
        }

        private void LoadCustomMappings()
        {
            var mapsFrom = MapperProfileHelper.LoadCustomMappings(Assembly.GetExecutingAssembly());

            foreach (var map in mapsFrom)
            {
                map.CreateMappings(this);
            }

            var assembly = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(a => a.GetName().Name == "Northwind.Application.Commands");
            mapsFrom = MapperProfileHelper.LoadCustomMappings(assembly);
            foreach (var map in mapsFrom)
            {
                map.CreateMappings(this);
            }

            assembly = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(a => a.GetName().Name == "Northwind.Application.Queries");
            mapsFrom = MapperProfileHelper.LoadCustomMappings(assembly);
            foreach (var map in mapsFrom)
            {
                map.CreateMappings(this);
            }
        }
    }
}
