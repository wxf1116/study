using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace WebApp002.Models
{
    public class EventsAndMenus
    {
        private IEnumerable<Event> events = null;
        public IEnumerable<Event> Events
        {
            get
            {
                return events ?? (events = new List<Event>()
                {
                    new Event {Id = 1, Text = "Abu Dhabi", Day = new DateTime(2014,10,26)},
                    new Event {Id = 2, Text = "USA", Day = new DateTime(2014,11,9)},
                    new Event {Id = 3, Text = "Brasil", Day = new DateTime(2014,11,30)}
                });
            }
        }
        private IEnumerable<Menu2> menus = null;
        public IEnumerable<Menu2> Menus
        {
            get
            {
                return menus ?? (menus = new List<Menu2>() 
                { 
                    new Menu2 {Id = 1, Text = "BBBR", Price = 16.9, Category = "Main"},
                    new Menu2 {Id = 1, Text = "CaBRP", Price = 12.9, Category = "Main"},
                    new Menu2 {Id = 1, Text = "CMSwSM", Price = 6.9, Category = "Soup"}
                });
            }
        }
    }
}