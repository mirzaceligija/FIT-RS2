using AutoMapper;
using ProjectWe.Model.Requests;
using ProjectWe.Model.SearchObjects;
using ProjectWe.Services.Database;
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
        public ProjectsService(_160020Context context, IMapper mapper) : base(context, mapper)
        {
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
    }
}
