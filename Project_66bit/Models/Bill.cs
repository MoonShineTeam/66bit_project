namespace Project_66bit.Models
{
    public class Bill
    {
        public long Id { get; set; }
        public double TotalSum { get; set; }

        public long UserId { get; set; }
        public virtual User User { get; set; }
    }
}