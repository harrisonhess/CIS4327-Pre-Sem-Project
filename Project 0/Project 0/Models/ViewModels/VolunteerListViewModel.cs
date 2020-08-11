using System.Collections.Generic;
using Project_0.Models;
namespace Project_0.Models.ViewModels
{
    public class VolunteerListViewModel
    {
        public IEnumerable<Volunteer> Volunteers { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}