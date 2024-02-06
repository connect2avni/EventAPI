using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventData.Repository;
using EventEntity;

/*namespace EventBusiness.Services*/
namespace EventData.Repository
{
    public class EventService
    {
        private readonly IEventRepository _eventRepository;
        public EventService(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }
        public bool AddEvent(EventModel eventData)
        {
            bool status= _eventRepository.AddEvent(eventData);
            return status;

        }
    }

    
}
