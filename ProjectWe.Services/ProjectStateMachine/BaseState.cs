using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using ProjectWe.Model.Requests;
using ProjectWe.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services.ProjectStateMachine
{
    public class BaseState
    {
        public IMapper Mapper { get; set; }
        public IServiceProvider ServiceProvider { get; set; }
        public _160020Context Context { get; set; } = null;
        public Database.Project CurrentEntity { get; set; }
        public string CurrentState { get; set; }

        public BaseState(IMapper mapper, IServiceProvider serviceProvider, _160020Context context)
        {
            Mapper = mapper;
            ServiceProvider = serviceProvider;
            Context = context;
        }

        public virtual Model.Project Insert(ProjectInsertRequest request)
        {
            throw new Exception("Not allowed");
        }

        public virtual void Update(ProjectUpdateRequest request)
        {
            throw new Exception("Not allowed");
        }

        public virtual void Activate()
        {
            throw new Exception("Not allowed");
        }

        public virtual void Hide()
        {
            throw new Exception("Not allowed");
        }

        public virtual void Delete()
        {
            throw new Exception("Not allowed");
        }

        public BaseState CreateState(string stateName)
        {
            switch (stateName)
            {
                case "initial":
                    return ServiceProvider.GetService<InitialProjectState>();
                    break;
                case "draft":
                    return ServiceProvider.GetService<DraftProjectState>();
                case "active":
                    return ServiceProvider.GetService<ActiveProjectState>();
                default:
                    throw new Exception("Not supported");
            }
        }

        public virtual List<string> AllowedActions()
        {
            return new List<string>();
        }
    }
}
