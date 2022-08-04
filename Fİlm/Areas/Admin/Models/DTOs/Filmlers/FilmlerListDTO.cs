using Microsoft.AspNetCore.Mvc;

namespace FİlmMvc.Areas.Admin.Models.DTOs.Filmlers
{
    [Area("Admin")]
    public class FilmlerListDTO
    {
        public int Id { get; set; }
        public string FilmAdi { get; set; }
        public string? Aciklama { get; set; }
        public DateTime YapimYili { get; set; }
        public string? AldigiOduller { get; set; }
        public decimal? Fiyat { get; set; }
        public DateTime EklemeTarihi { get; set; }
        public int KategoriId { get; set; }
    }
}
