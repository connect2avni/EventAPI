using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventData.DataContext
{
    public class EventDbContext : DbContext
    {
        //connection establishment
        //Dbset configure
        public EventDbContext(DbContextOptions<EventDbContext> options):base (options)
            {
            //connection establishment
            }
        public DbSet<EventEntity.EventModel> EventModels { get; set; }
    }
}
