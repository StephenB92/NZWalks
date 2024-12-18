using System.ComponentModel.DataAnnotations;

namespace NZWalks.API.Model.DTO
{
    public class UpdateRegionRequestDTO
    {
        [Required]
        [MinLength(3, ErrorMessage = "Code has to be a minimum of 3 characters")]
        [MaxLength(3, ErrorMessage = "Code has to be a maximum of 3 characters")]
        public required string Code { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Code can't be a maximum of 100 characters")]
        public required string Name { get; set; }
    }
}
