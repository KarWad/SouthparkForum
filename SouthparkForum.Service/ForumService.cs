using Microsoft.EntityFrameworkCore;
using SouthparkForum.Data.Models;
using SouthParkForum.Data;
using SouthParkForum.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SouthparkForum.Service
{
        public class ForumService : IForum
        {
            private readonly ApplicationDbContext _context;

            public ForumService(ApplicationDbContext context)
            {
                _context = context;
            }

            public Forum GetById(int id)
            {
                var forum = _context.Forums.Where(f => f.Id == id)
                    .Include(f => f.Posts).ThenInclude(p => p.User)
                    .Include(f => f.Posts).ThenInclude(p => p.Replies).ThenInclude(r => r.User)
                    .FirstOrDefault();
                return forum;
                //throw new NotImplementedException();
            }

            public IEnumerable<Forum> GetAll()
            {
                return _context.Forums
                    .Include(forum => forum.Posts);
                //throw new NotImplementedException();
            }

            public IEnumerable<ApplicationUser> GetAllActiveUsers()
            {
                throw new NotImplementedException();
            }

            public Task Create(Forum forum)
            {
                throw new NotImplementedException();
            }

            public Task Delete(int forumId)
            {
                throw new NotImplementedException();
            }

            public Task UpdateForumTitle(int forumId, string newTitle)
            {
                throw new NotImplementedException();
            }

            public Task UpdateForumDescription(int forumId, string newDescription)
            {
                throw new NotImplementedException();
            }
        }
    }