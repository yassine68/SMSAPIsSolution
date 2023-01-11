using Microsoft.AspNetCore.Mvc;
using SMSAPIs.Dtos;
using SMSAPIs.Servicies;

namespace SMSAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SMSController : ControllerBase
    {
        private readonly ISMSService _SMSService;

        public SMSController(ISMSService SMSService)
        {
            _SMSService = SMSService;
        }
        [HttpPost]
        [ActionName("Send")]
        public async Task<IActionResult> SendAsync(MessageRessourceDto model)
        {
            try
            {
                var result = await _SMSService.SendAsync(model.Message, model.To);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
