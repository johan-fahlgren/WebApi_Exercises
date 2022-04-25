using Microsoft.AspNetCore.Mvc;

namespace WebApi_TodoList.Controllers
{
    //[Route("api/v{version:apiVersion}")]
    [Route("api")]
    [ApiController]
    public class ClockController : ControllerBase
    {
        [ApiVersion("1.1")]
        [Route("clock")]
        [HttpGet]
        public ActionResult<ClockTime> GetTimeV1_1()
        {
            return new ClockTime { Time = DateTime.Now };
        }


        [ApiVersion("1.2")]
        [Route("clock")]
        [HttpGet]
        public ActionResult<ClockTime2> GetTimeV1_2()
        {
            var now = DateTime.Now;

            return new ClockTime2
            {
                Year = now.Year,
                Month = now.Month,
                Day = now.Day,
                Hour = now.Hour,
                Minute = now.Minute,
                second = now.Second
            };
        }

    }






    public class ClockTime //DTO
    {
        public DateTime Time { get; set; }
    }

    public class ClockTime2 //DTO
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int second { get; set; }
    }
}
