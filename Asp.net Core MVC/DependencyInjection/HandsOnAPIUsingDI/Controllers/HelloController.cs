using HandsOnAPIUsingDI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingDI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        //private readonly MessageService _messageService;
        //public HelloController()
        //{
        //    _messageService = new MessageService();
        //}
        private readonly IMessageService _messageService;

        // Constructor Injection
        public HelloController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_messageService.Flowers);
        }
        [HttpPost]
        public IActionResult Add(string flower)
        {
            _messageService.Send(flower);
            return Ok(flower);
        }
    }
}
