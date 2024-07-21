using AutoMapper;
using CalculatorAPI.Entity;
using CalculatorAPI.Models;
using CalculatorAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CalculatorAPI.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IAccountService _accountService;
        private IMapper _mapper;

        public AccountController(IAccountService accountService, IMapper mapper) {
            _accountService = accountService;
            _mapper = mapper;
        }
        [HttpPost("register")]
        public ActionResult RegisterUser([FromBody] User user)
        {
            _accountService.RegisterUser(user);
            return Ok();
        }
        [HttpPost("login")]
        public ActionResult Login([FromBody] LoginDto dto)
        {
            string token = _accountService.GenerateJwt(dto);
            return Ok(token);
        }
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAll()
        {
            var users = _accountService.GetAll();
            return Ok(users);
        }
        [HttpGet("envelope/{email}")]
        public ActionResult<IEnumerable<Envelope>> GetUserEnvelops([FromRoute] string email)
        {
            var userEnvelops = _accountService.GetUserEnvelops(email);
            return Ok(userEnvelops);
        }
        [HttpGet("{userId}/envelope")]
        public ActionResult<List<EnvelopeDto>> GetEnvelops([FromRoute] int userId)
        {
            var userEnvelops = _accountService.GetEnvelops(userId);
            return Ok(userEnvelops);
        }        
        [HttpGet("user/{email}")]
        public ActionResult<User> GetUserName([FromRoute] string email)
        {
            var userName = _accountService.GetUserName(email);
            return Ok(userName);
        }
        [HttpPost("{userId}/envelope")]
        public ActionResult AddEnvelope([FromRoute] int userId, [FromBody] CreateEnvelopeDto envelope)
        {
            var newEnvelopeId = _accountService.AddEnvelop(userId, envelope);

            return Created($"api/account/{userId}/envelope/{newEnvelopeId}", null);
            
        }
        [HttpPost("{envelopeId}/material")]
        public ActionResult AddMaterial([FromRoute] int envelopeId, [FromBody] CreateMaterialDto material)
        {
            var newMateroalId = _accountService.AddMaterial(envelopeId, material);

            return Created($"api/account/{envelopeId}/material/{newMateroalId}", null);

        }
        [HttpGet("{envelopeId}/material/{materialId}")]
        public ActionResult<MaterialDto> Get([FromRoute] int envelopeId, [FromRoute] int materialId)
        {
            MaterialDto material = _accountService.GetById(envelopeId, materialId);
            return Ok(material);
        }
        [HttpGet("{envelopeId}/material/")]
        public ActionResult<List<MaterialDto>> Get([FromRoute] int envelopeId)
        {
            var materials = _accountService.GetAll(envelopeId);
            return Ok(materials);
        }
    }
}
