using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SouthparkForum.Models.ManageViewModels
{
    public class RemoveLoginViewModel
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
    }
}