using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.API.Models.Author
{
    public class AuthorUpdateDto : BaseDto
    {
        [System.ComponentModel.DataAnnotations.Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(250)]
        public string Bio { get; set; }
    }
}
