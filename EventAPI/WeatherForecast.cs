using EventData.Repository;
using EventEntity;

namespace EventBusiness.Services
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
                bool status = _eventRepository.AddEvent(eventData);
                return status;
            }
        }
    
}