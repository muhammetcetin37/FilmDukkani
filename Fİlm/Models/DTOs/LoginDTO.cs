using System.ComponentModel.DataAnnotations;

namespace FİlmMvc.Models.DTOs
{
    public class LoginDTO
    {

        [Required]
        [MinLength(5, ErrorMessage = "Email Alani en az 5 karakter olmalidir")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required]
        [DataType(DataType.Password)]// şifreyi noktalı bir şekilde çıkartmaya yarıyor
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
