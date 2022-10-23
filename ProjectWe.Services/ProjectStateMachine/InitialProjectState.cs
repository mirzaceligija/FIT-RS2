using AutoMapper;
using ProjectWe.Model.Requests;
using ProjectWe.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services.ProjectStateMachine
{
    public class InitialProjectState : BaseState
    {
        public InitialProjectState(IMapper mapper, IServiceProvider serviceProvider, _160020Context context) : base(mapper, serviceProvider, context)
        {
        }

        public override Model.Project Insert(ProjectInsertRequest request)
        {
            var set = Context.Set<Database.Project>();

            Database.Project entity = Mapper.Map<Database.Project>(request);
            CurrentEntity = entity;
            CurrentEntity.StateMachine = "draft";

            set.Add(entity);
            Context.SaveChanges();

            return Mapper.Map<Model.Project>(entity);
        }
    }
}
