using System.ComponentModel.DataAnnotations;

namespace FİlmMvc.Models.DTOs
{
    public class RegisterDTO
    {

        [Required]
        public string Ad { get; set; }


        [Required]
        public string Soyad { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [MinLength(11, ErrorMessage = "TcNo Alani En Az 11 Karakter Olmalidir.")]
        public string TcNo { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = "Gsm Alani En Az 10 Karakter Olmalidir.")]
        [MaxLength(11, ErrorMessage = "Gsm Alani 11 Karakterden Fazla olmamalidir.")]
        public string Gsm { get; set; }


        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]

        public string Adresler { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }



        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string RePassword { get; set; }

        public bool IAgree { get; set; }
    }
}
