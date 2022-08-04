using Microsoft.AspNetCore.Mvc;

namespace FİlmMvc.Areas.Admin.Models.DTOs.Tedarikcis
{
    [Area("Admin")]
    public class TedarikciUpdateDTO
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Gsm { get; set; }
        public string? Email { get; set; }
        public string Adres { get; set; }
    }
}
