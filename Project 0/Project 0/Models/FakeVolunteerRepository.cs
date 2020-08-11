using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Project_0.Models
{
    public class FakeVolunteerRepository : IVolunteerRepository
    {
        IEnumerable<Volunteer> IVolunteerRepository.Volunteers => new List<Volunteer>() {
            new Volunteer { FirstName = "John", LastName = "Doe", Username = "johndoe1", Password = "password123" },
            new Volunteer { FirstName = "Jane", LastName = "Doe", Username = "janedoe2", Password = "password456" },
            new Volunteer { FirstName = "Harry", LastName = "Mess", Username = "hairymess", Password = "fakepass69" },
        };

        public Volunteer DeleteVolunteer(string username)
        {
            throw new NotImplementedException();
        }

        public void SaveVolunteer(Volunteer volunteer)
        {
            throw new NotImplementedException();
        }
    }
}
