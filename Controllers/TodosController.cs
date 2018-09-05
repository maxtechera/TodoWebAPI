using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<TodoItem>> Get() {
            return new List<TodoItem>() {
               new TodoItem { Name = "Item1" },
               new TodoItem { Name = "Item2" },
               new TodoItem { Name = "Item3" },
            };
        }
    }
}
