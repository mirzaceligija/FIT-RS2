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
            CreateMap<Database.UserRole, Model.UserRole>();
            CreateMap<Database.Role, Model.Role>();
            CreateMap<Database.Project, Model.Project>();
            CreateMap<Database.Category, Model.Category>();
            CreateMap<Database.Objective, Model.Objective>();
            CreateMap<Database.Output, Model.Output>();

            CreateMap<CategoryUpsertRequest, Database.Category>();
            CreateMap<UserInsertRequest, Database.User>();
            CreateMap<UserUpdateRequest, Database.User>();
            CreateMap<ProjectInsertRequest, Database.Project>();
            CreateMap<ProjectUpdateRequest, Database.Project>();
            CreateMap<ObjectiveInsertRequest, Database.Objective>();
            CreateMap<ObjectiveUpdateRequest, Database.Objective>();
            CreateMap<OutputInsertRequest, Database.Output>();
            CreateMap<OutputUpdateRequest, Database.Output>();
        }
    }
}
