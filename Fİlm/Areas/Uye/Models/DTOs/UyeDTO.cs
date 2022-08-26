using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FİlmMvc.Areas.Uye.Models.DTOs
{
    [Area("Uye")]
    [Authorize]
    public class UyeDTO
    {

        [Required]
        [MinLength(10, ErrorMessage = "Email Alani en az 10 karakter olmalidir")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required]
        [DataType(DataType.Password)]// şifreyi noktalı bir şekilde çıkartmaya yarıyor

        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
