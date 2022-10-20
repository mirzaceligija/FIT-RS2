using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWe.Model;
using ProjectWe.Model.Requests;
using ProjectWe.Model.SearchObjects;
using ProjectWe.Services;

namespace ProjectWe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : BaseCRUDController<Project, ProjectSearchObject, ProjectInsertRequest, ProjectUpdateRequest>
    {
        public ProjectsController(IProjectsService projectsService) : base(projectsService)
        {

        }
    }
}
