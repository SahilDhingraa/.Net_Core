using Microsoft.AspNetCore.Mvc;
using udemy1.Services.FightService;

namespace udemy1.Controllers
{
    [ApiController]
    [Route("[controller")]
    public class FightController : ControllerBase
    {
        private readonly IFightService _fightService;
        public FightController(IFightService fightService)
        {
            _fightService = fightService;
            
        }
    }
}