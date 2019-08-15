using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Northwind.Application.Queries.Category;
using Northwind.Application.Queries.Models;

namespace Northwind.WebUI.Controllers
{
    public class CategoriesController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryPreviewDto>>> GetCategoryPreview([FromQuery] GetCategoryPreviewQuery query)
        {
            return Ok(await Mediator.Send(query));
        }
    }
}
