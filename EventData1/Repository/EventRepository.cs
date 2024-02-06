using EventData.DataContext;
using EventEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventData.Repository
{
    public class EventRepository : IEventRepository
    {
        private readonly EventDbContext _eventDbContext;

        public EventRepository(EventDbContext eventDbContext)
        {
            _eventDbContext = eventDbContext;

        }
        public bool AddEvent(EventModel eventData)
        {
            //insert into EventModel values('','','')
            _eventDbContext.EventModels.Add(eventData);
            //execute sql statement
            _eventDbContext.SaveChanges();
            return true;
           
        }

        public bool DeleteEvent(int id)
        {
           EventModel eventModel= _eventDbContext.EventModels.Find(id);
            _eventDbContext.EventModels.Remove(eventModel);
            _eventDbContext.SaveChanges();
            return true;

        }

        public EventModel GetEventModel(int id)
        {
            
            EventModel eventModel = _eventDbContext.EventModels.Find(id);
            return eventModel;
        }

        public IList<EventModel> GetEvents()
        {
            //select * from EventModel 
           IList<EventModel>list= _eventDbContext.EventModels.ToList();
            return list;
        }

        public bool UpdateEvent(EventModel eventData)
        {
            //update eventmodel set name=eventData.name, type=eventData.type where id = eventData.id
            _eventDbContext.Entry(eventData).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
            _eventDbContext.SaveChanges();//commit
            return true;
        }
    }
}
