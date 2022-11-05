using Microsoft.AspNetCore.Authorization;
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

        [Authorize("Manager")]
        public override Model.Budget Get(int id)
        {
            return base.Get(id);
        }

        [Authorize("Manager")]
        public override Model.Budget Insert([FromBody] BudgetInsertRequest insert)
        {
            return base.Insert(insert);
        }

        [Authorize("Manager")]
        public override Model.Budget Update(int id, [FromBody] BudgetUpdateRequest update)
        {
            return base.Update(id, update);
        }
    }
}
