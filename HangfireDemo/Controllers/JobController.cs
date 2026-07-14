using Hangfire;
using Microsoft.AspNetCore.Mvc;

namespace HangfireDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobController : ControllerBase
    {
        [HttpGet("fire-and-forget")]
        public IActionResult FireAndForget()
        {
            BackgroundJob.Enqueue(() => Console.WriteLine("Merhaba Hangfire!"));

            return Ok("Job oluşturuldu.");
        }

        [HttpGet("delayed")]
        public IActionResult Delayed()
        {
            BackgroundJob.Schedule(
                () => Console.WriteLine("5 saniye sonra çalışan görev."),
                TimeSpan.FromSeconds(5));

            return Ok("Delayed Job oluşturuldu.");
        }

        [HttpGet("recurring")]
        public IActionResult Recurring()
        {
            RecurringJob.AddOrUpdate(
                "recurring-job",
                () => Console.WriteLine("Recurring Job çalıştı."),
                Cron.Minutely);

            return Ok("Recurring Job oluşturuldu.");
        }
    }
}
