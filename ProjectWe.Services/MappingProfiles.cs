using AutoMapper;
using ProjectWe.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<Database.User, Model.User>();
            CreateMap<Database.Project, Model.Project>();

            CreateMap<ProjectInsertRequest, Database.Project>();
            CreateMap<ProjectUpdateRequest, Database.Project>();
        }
    }
}
