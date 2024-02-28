using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientsController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpPost]
        public IActionResult Add(CreateClientRequest createClientRequest)
        {
            CreatedClientResponse createdClientResponse = _clientService.Add(createClientRequest);
            return Ok();
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_clientService.GetAll());
        }
    }
}
