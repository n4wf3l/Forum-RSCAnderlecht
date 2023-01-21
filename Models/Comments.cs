
namespace RSCAnderlechtF.Models;

public class Comments
{
    public class Comment { 
        public int ID { get; set; }
        public string Content { get; set; } = "";
        public string User { get; set; } 
        public DateTime Created { get; set; } = DateTime.Now;
        public int PostID { get; set; } 
        public Post Post { get; set; } }
}
