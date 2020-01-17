using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripTracker.BackService.Models
{
    public class Repository
    {
        //Dummy data
        private List<Trip> MyTrips = new List<Trip>
        {
            new Trip
            {
                Id=1,
                Name = "MVP",
                StartDate = new DateTime(2018,2,2),
                EndDate = new DateTime(2018,2,10)
            },
            new Trip
            {
                Id=2,
                Name= "test",
                StartDate = new DateTime(2018,2,2),
                EndDate = new DateTime(2018,12,10)
            },
                new Trip
            {
                Id=3,
                Name= "build",
                StartDate = new DateTime(2018,5,22),
                EndDate = new DateTime(2018,7,9)
            },
        };
        //Methods for repo
        public List<Trip> Get()
        {
            return MyTrips;
        }
        public Trip Get(int id)
        {
            return MyTrips.First(t=> t.Id == id);
        }
        public void Add(Trip newTrip)
        {
            MyTrips.Add(newTrip);
        }
        public void Update(Trip tripToUpdate)
        {
            MyTrips.Remove(MyTrips.First(t => t.Id == tripToUpdate.Id));
            Add(tripToUpdate);
        }
        public void Remove(int Id)
        {
            MyTrips.Remove(MyTrips.First(t => t.Id == Id));
        }

    }
}
