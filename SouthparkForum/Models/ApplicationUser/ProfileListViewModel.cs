using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SouthparkForum.Models.ApplicationUser
{
    public class ProfileListViewModel
    {
        public IEnumerable<ProfileViewModel> Profiles { get; set; }
    }
}
