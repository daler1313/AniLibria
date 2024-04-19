namespace Domain.Entity
{
    public class User : BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<Reading> Readings { get; set; }
        public virtual ICollection<Vewing> Vewings { get; set; } 
    }
}
