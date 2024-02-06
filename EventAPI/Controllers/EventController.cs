using EventBusiness.Services;
using EventEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;
using EventData.DataContext;
using EventData.Repository;
using Microsoft.EntityFrameworkCore;



namespace EventAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly EventBusiness.Services.EventService _eventService;
        public EventController(EventBusiness.Services.EventService eventService)
        {
            _eventService = eventService;
        }
        [HttpPost]
        public IActionResult AddEvent(EventModel eventData)
        {
            bool status = _eventService.AddEvent(eventData);
            if (status)
                return Ok("Inserted");//200 status ok
            else 
                return BadRequest();//400 error
        }
    }

}
