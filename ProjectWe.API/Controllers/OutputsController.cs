﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWe.Controllers;
using ProjectWe.Model.Requests;
using ProjectWe.Model.SearchObjects;
using ProjectWe.Services;

namespace ProjectWe.API.Controllers
{
    public class OutputsController : BaseCRUDController<Model.Output, OutputSearchObject, OutputInsertRequest, OutputUpdateRequest>
    {
        public OutputsController(IOutputsService service) : base(service)
        {
        }
    }
}
