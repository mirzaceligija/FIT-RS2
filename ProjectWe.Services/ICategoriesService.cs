using ProjectWe.Model.Requests;
using ProjectWe.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services
{
    public interface ICategoriesService : ICRUDService<Model.Category, CategorySearchObject, CategoryUpsertRequest, CategoryUpsertRequest>
    {
    }
}
