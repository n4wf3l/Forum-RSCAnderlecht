using System;
using System.Collections.Generic;

namespace RSCAnderlechtF.Models
{
    public partial class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; } = null!;
        public int PostId { get; set; }
        public string UserId { get; set; } = null!;
        public DateTime CreatedAt { get; set; }

        public virtual Post Post { get; set; } = null!;
        public virtual AspNetUser User { get; set; } = null!;
    }
}
