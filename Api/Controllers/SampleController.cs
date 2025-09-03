using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SampleController : ControllerBase
{
    public class SampleStartRequest
    {
        public string Ticket { get; set; } = string.Empty;
    }

    public class SampleStartResponse
    {
        public bool Result { get; set; }
        public bool Objects { get; set; }
    }

    [HttpPost("request-start")]
    public IActionResult RequestStart([FromBody] SampleStartRequest request)
    {
        var response = new SampleStartResponse
        {
            Result = true,
            Objects = true
        };
        return Ok(response);
    }
}

