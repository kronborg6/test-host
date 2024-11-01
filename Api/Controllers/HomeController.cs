using Microsoft.AspNetCore.Mvc;
namespace Api.Controllers;

[ApiController]
[Route("/")]
public class HomeController : ControllerBase {
  [HttpGet()]
  public IActionResult Home() { return Ok(); }
  [HttpGet("env")]
  public IActionResult GetEnv() {
    var en = Environment.GetEnvironmentVariable("Work") ?? "Does not work";
    var data = new { GG = true, Env = en };
    return Ok(data);
  }
}
