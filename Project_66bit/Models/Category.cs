namespace Project_66bit.Models
{
    public class Category
    {
        public long Id { get; set; }
        public string Name {get; set;}
        
        public long TypeId { get; set; }
        public virtual Type Type { get; set; }
    }
}