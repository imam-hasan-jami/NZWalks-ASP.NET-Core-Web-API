namespace NZWalks.API.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthInKm { get; set; }

        // WalkImageUrl is optional, so it can be null. Used ? for nullable reference types.
        public string? WalkImageUrl { get; set; }
        public Guid DifficultyId { get; set; }
        public Guid RegionId { get; set; }


        // Navigation properties
        public Difficulty Difficulty { get; set; }
        public Region Region { get; set; }
    }
}
