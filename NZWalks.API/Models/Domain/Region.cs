namespace NZWalks.API.Models.Domain
{
    public class Region
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        // RegionImageUrl is optional, so it can be null. Used ? for nullable reference types.
        public string? RegionImageUrl { get; set; }
    }
}
