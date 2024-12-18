namespace NZWalks.API.Model.DTO
{
    public class RegionDTO
    {
        public Guid Id { get; set; }
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required string? RegionImageUrl { get; set; }
    }
}
