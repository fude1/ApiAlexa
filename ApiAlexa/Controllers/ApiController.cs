using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiAlexa.Controllers
{
    [ApiController]
    [Route("api.aep/TVMStatus")]
    public class ApiController : ControllerBase
    {
        
        private readonly ILogger<ApiController> _logger;

        public ApiController(ILogger<ApiController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public TVMStatus Get()
        {
            TVMStatus _TVMStatus = new TVMStatus
            {

                Date = DateTime.Now.Date,
                SN = Program._NewTVMSN,
                Status = Program._NewTVMStatus,
                Lingua = Program._NewLingua,
                TicketStatus = Program._TicketStatus,
                TVMTicketStatus = Program._TVMTicketStatus,
            };

            return _TVMStatus;
        }
        public TVMStatus Put(TVMStatus _NewStatus)
        {
            Program._NewTVMStatus = _NewStatus.Status;
            Program._NewTVMSN = _NewStatus.SN;
            Program._NewLingua = _NewStatus.Lingua;
            Program._TicketStatus = _NewStatus.TicketStatus;
            Program._TVMTicketStatus = _NewStatus.TVMTicketStatus;

            return _NewStatus; 
        }
    }

}
