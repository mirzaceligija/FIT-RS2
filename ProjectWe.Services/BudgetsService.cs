using AutoMapper;
using ProjectWe.Model.Requests;
using ProjectWe.Model.SearchObjects;
using ProjectWe.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services
{
    public class BudgetsService : BaseCRUDService<Model.Budget, Database.Budget, BudgetSearchObject, BudgetInsertRequest, BudgetUpdateRequest>, IBudgetsService
    {
        public BudgetsService(_160020Context context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
