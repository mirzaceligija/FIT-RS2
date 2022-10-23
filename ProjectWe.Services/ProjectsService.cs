using AutoMapper;
using ProjectWe.Model.Requests;
using ProjectWe.Model.SearchObjects;
using ProjectWe.Services.Database;
using ProjectWe.Services.ProjectStateMachine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services
{
    public class ProjectsService : BaseCRUDService<Model.Project, Database.Project, ProjectSearchObject, ProjectInsertRequest, ProjectUpdateRequest>,
        IProjectsService
    {
        public BaseState BaseState { get; set; }

        public ProjectsService(_160020Context context, IMapper mapper, BaseState baseState) : base(context, mapper)
        {
            BaseState = baseState;
        }

        public override IEnumerable<Model.Project> GetList(ProjectSearchObject search = null)
        {
            return base.GetList(search);
        }

        public override IQueryable<Database.Project> AddFilter(IQueryable<Database.Project> query, ProjectSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if(!string.IsNullOrWhiteSpace(search?.Name))
            {
                filteredQuery = filteredQuery.Where(x => x.Name == search.Name);
            }

            if(!string.IsNullOrWhiteSpace(search?.Description))
            {
                filteredQuery = filteredQuery.Where(x => x.Description == search.Description);
            }

            return filteredQuery;
        }

        public override Model.Project Insert(ProjectInsertRequest insert)
        {
            var state = BaseState.CreateState("initial");
            return state.Insert(insert);
        }

        public override Model.Project Update(int id, ProjectUpdateRequest update)
        {
            var project = Context.Projects.Find(id);

            var state = BaseState.CreateState(project.StateMachine);
            state.CurrentEntity = project;
            state.Update(update);

            return Get(id);
        }

        public Model.Project Activate(int id)
        {
            var project = Context.Projects.Find(id);

            var state = BaseState.CreateState(project.StateMachine);
            state.CurrentEntity = project;
            state.Activate();

            return Get(id);
        }

        public List<string> AllowedActions(int id)
        {
            var product = Get(id);
            var state = BaseState.CreateState(product.StateMachine);

            return state.AllowedActions();
        }
    }
}
