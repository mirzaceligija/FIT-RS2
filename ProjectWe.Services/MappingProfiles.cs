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
            CreateMap<Database.Category, Model.Category>();

            CreateMap<CategoryUpsertRequest, Database.Category>();
            CreateMap<UserInsertRequest, Database.User>();
            CreateMap<UserUpdateRequest, Database.User>();
            CreateMap<ProjectInsertRequest, Database.Project>();
            CreateMap<ProjectUpdateRequest, Database.Project>();
        }
    }
}
