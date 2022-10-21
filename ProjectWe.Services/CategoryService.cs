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
    public class CategoryService : BaseCRUDService<Model.Category, Database.Category, CategorySearchObject, CategoryUpsertRequest, CategoryUpsertRequest>, ICategoryService
    {
        public CategoryService(_160020Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Database.Category> AddFilter(IQueryable<Database.Category> query, CategorySearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if(!string.IsNullOrWhiteSpace(search?.Name))
            {
                filteredQuery = filteredQuery.Where(s => s.Name == search.Name);
            }

            if(search?.CategoryId.HasValue == true)
            {
                filteredQuery = filteredQuery.Where(x => x.CategoryId == search.CategoryId);
            }

            return filteredQuery;
        }
    }
}
