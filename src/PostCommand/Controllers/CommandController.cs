using Microsoft.AspNetCore.Mvc;

namespace PostCommand.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CommandController : ControllerBase
    {
        [HttpPost]
        public void PostCommand(string command)
        {
            ExecuteCommand.CaptureCommandOutput(command);

        }


    }
}
