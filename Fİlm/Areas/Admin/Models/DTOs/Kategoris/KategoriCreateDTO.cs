using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FİlmMvc.Areas.Admin.Models.DTOs
{
    [Area("Admin")]
    public class KategoriCreateDTO
    {
        public int KategoriId { get; set; }
        [Required(ErrorMessage = "KategoriAdi Alani Bos Gecilemez")]
        [StringLength(maximumLength: 20, ErrorMessage = "20 karakterden fazla Girilemez")]
        public string KategoriAdi { get; set; }
        [Required(ErrorMessage = "Aciklama Alani Bos Gecilemez")]

        public string Aciklama { get; set; }
    }
}
