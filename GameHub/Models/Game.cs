namespace GameZone.Models
{
    public class Game:BaseEntity
    {
       
        [MaxLength(2500)]
        public string Description { get; set; } = string.Empty;
        [MaxLength(500)]
        public string Cover { get; set; } = string.Empty; // string is required by default
        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!;
        // many to many relation

        public ICollection<GameDevice> Devices { get; set; } =new List<GameDevice>();

    }
}
