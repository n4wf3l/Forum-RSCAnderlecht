namespace RSCAnderlechtF.Models
{
    public class AspNetUserRole
    {
        public int Id { get; set; }
        public string UserId { get; set; } = null!;
        public string RoleId { get; set; } = null!;

        public virtual AspNetUser User { get; set; } = null!;
        public virtual AspNetRole Role { get; set; } = null!;
    }
}
