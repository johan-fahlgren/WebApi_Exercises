using Microsoft.AspNetCore.Mvc;

namespace WebApi_TodoList.Controllers
{
    [Route("api")]
    [ApiController]
    public class TodoListController : ControllerBase
    {
        //TODO add POST function
        //TODO GET single TODO item
        //TODO implement CRUD (create, read, update, delete)

        [Route("todos")]
        [HttpGet]
        public List<string> getTodos(int? count)
        {
            int c = count ?? 3;

            return new List<string>
            {
                "handla mjölk",
                "fixa grejer",
                "göra saker"
            }.Take(c)
                .ToList();
        }
    }

}
