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

        public static List<string> list = new List<string>
        {
            "handla mjölk",
            "fixa grejer",
            "göra saker"
        };


        [Route("todos")]
        [HttpGet]
        public ActionResult<List<string>> GetTodos(int? count)
        {
            int c = count ?? list.Count;

            if (c > 0)
                return Ok(list.Take(c).ToList());

            return NotFound();

        }



        [Route("todos/{index:int}")]
        [HttpGet]
        public ActionResult<string> GetSingleTodo(int index)
        {
            if (list[index] != null)
                return Ok(list[index]);

            return NotFound();
        }



    }

}
