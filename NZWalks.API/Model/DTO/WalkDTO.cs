namespace NZWalks.API.Model.DTO
{
    public class WalkDTO
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public double LengthInKm { get; set; }
        public string? WalkImageUrl { get; set; }
        public required RegionDTO Region { get; set; }
        public required DifficultyDTO Difficulty { get; set; }

    }
}
