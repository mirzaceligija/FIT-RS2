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
    public class DraftProjectState : BaseState
    {
        public DraftProjectState(IMapper mapper, IServiceProvider serviceProvider, _160020Context context) : base(mapper, serviceProvider, context)
        {
        }

        public override void Update(ProjectUpdateRequest request)
        {
            var set = Context.Set<Database.Project>();
            Mapper.Map(request, CurrentEntity);

            CurrentEntity.StateMachine = "draft";
            Context.SaveChanges();
        }

        public override void Activate()
        {
            CurrentEntity.StateMachine = "active";
            Context.SaveChanges();
        }

        public override List<string> AllowedActions()
        {
            var list = base.AllowedActions();

            list.Add("update");
            list.Add("activate");
            list.Add("hide");

            return list;
        }
    }
}
