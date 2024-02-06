using EventEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventData.Repository
{
   public  interface IEventRepository
    {
        bool AddEvent(EventModel eventData);
        bool UpdateEvent(EventModel eventData);
        bool DeleteEvent(int id);
        EventModel GetEventModel(int id);
        IList<EventModel> GetEvents();

    }
}

