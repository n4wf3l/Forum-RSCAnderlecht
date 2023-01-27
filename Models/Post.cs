using System;
using System.Collections.Generic;

namespace RSCAnderlechtF.Models
{
    public partial class Post
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }
        public string Content { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public DateTime CreateAt { get; set; }

        public virtual AspNetUser User { get; set; } = null!;
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
