using System.ComponentModel.DataAnnotations;

namespace NZWalks.API.Model.DTO
{
    public class RegisterRequestDTO
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public required string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public required string Password { get; set; }

        public required string[] Roles {  get; set; }

    }
}
