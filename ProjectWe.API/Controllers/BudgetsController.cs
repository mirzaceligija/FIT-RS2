using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWe.Controllers;
using ProjectWe.Model.Requests;
using ProjectWe.Model.SearchObjects;
using ProjectWe.Services;

namespace ProjectWe.API.Controllers
{
    public class BudgetsController : BaseCRUDController<Model.Budget, BudgetSearchObject, BudgetInsertRequest, BudgetUpdateRequest>
    {
        public BudgetsController(IBudgetsService service) : base(service)
        {
        }
    }
}
