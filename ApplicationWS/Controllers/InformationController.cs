using Application.Model.Request;
using Application.Model.Response;
using Application.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace ApplicationWS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InformationController : ControllerBase
    {
        private readonly IApplicationService _applicationService;
        private readonly ILogger<InformationController> _logger;

        public InformationController(ILogger<InformationController> logger, IApplicationService applicationService)
        {
            _logger = logger;
            this._applicationService = applicationService;
        }
        [HttpPost, Route("Information")]
        public ActionResult<string> CreateInformation(InformationRequest information)
        {
            var result = _applicationService.CreateInformation(information);
            return StatusCode(result.status ? 200 : 500, result.message);
        }
        [HttpPost, Route("Title")]
        public ActionResult<MultipleStepResponse> UpdateTitle(int informationId, string title)
        {
            var result = _applicationService.UpdateTitle(informationId, title);
            return StatusCode(result.status ? 200 : 500, new MultipleStepResponse() { InfomationId = result.informationId, Message = result.message });
        }

        [HttpPost, Route("Address")]
        public ActionResult<MultipleStepResponse> UpdateAddress(int informationId, AddressRequest address)
        {
            var result = _applicationService.UpdateAddress(informationId, address);
            return StatusCode(result.status ? 200 : 500, new MultipleStepResponse() { InfomationId = result.informationId, Message = result.message });
        }

        [HttpPost, Route("Country")]
        public ActionResult<MultipleStepResponse> UpdateCountry(int informationId, string country)
        {
            var result = _applicationService.UpdateCountry(informationId, country);
            return StatusCode(result.status ? 200 : 500, new MultipleStepResponse() { InfomationId = result.informationId, Message = result.message });
        }

        [HttpPost, Route("DateofBirth")]
        public ActionResult<MultipleStepResponse> UpdateDateofBirth(int informationId, DateTime dateOfBirth)
        {
            var result = _applicationService.UpdateDateofBirth(informationId, dateOfBirth);
            return StatusCode(result.status ? 200 : 500, new MultipleStepResponse() { InfomationId = result.informationId, Message = result.message });
        }

        [HttpPost, Route("Firstname")]
        public ActionResult<MultipleStepResponse> UpdateFirstname(int informationId, string firstname)
        {
            var result = _applicationService.UpdateFirstname(informationId, firstname);
            return StatusCode(result.status ? 200 : 500, new MultipleStepResponse() { InfomationId = result.informationId, Message = result.message });
        }

        [HttpPost, Route("Lastname")]
        public ActionResult<MultipleStepResponse> UpdateLastname(int informationId, string lastname)
        {
            var result = _applicationService.UpdateLastname(informationId, lastname);
            return StatusCode(result.status ? 200 : 500, new MultipleStepResponse() { InfomationId = result.informationId, Message = result.message });
        }

        [HttpPost, Route("Occupation")]
        public ActionResult<MultipleStepResponse> UpdateOccupation(int informationId, OccupationRequest occupation)
        {
            var result = _applicationService.UpdateOccupation(informationId, occupation);
            return StatusCode(result.status ? 200 : 500, new MultipleStepResponse() { InfomationId = result.informationId, Message = result.message });
        }
    }
}
