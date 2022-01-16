using SouthparkForum.Models.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SouthparkForum.Models.Forum
{
    public class ForumTopicViewModel
    {
        public ForumListingViewModel Forum { get; set; }
        public IEnumerable<PostListingViewModel> Posts { get; set; }
        public string SearchQuery { get; set; }
    }
}
