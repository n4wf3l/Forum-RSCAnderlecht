namespace RSCAnderlechtF.Models
{
    public class Post { 
        public int ID { get; set; } 
        public string Title { get; set; } = ""; 
        public string Body { get; set; } = "";
        public string Author { get; set; } = "";
        public DateTime Created { get; set; }= DateTime.Now; 
        public List<Comments> Comments { get; set; } }
}
