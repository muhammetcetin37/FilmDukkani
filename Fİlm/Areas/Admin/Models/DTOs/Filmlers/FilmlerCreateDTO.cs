using Film.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FİlmMvc.Areas.Admin.Models.DTOs.Filmlers
{
    [Area("Admin")]
    public class FilmlerCreateDTO
    {
        public string FilmAdi { get; set; }
        public string? Aciklama { get; set; }
        public string Yonetmen { get; set; }
        public string Oyuncular { get; set; }
        public string? TeknikOzellikler { get; set; }
        public DateTime YapimYili { get; set; }
        public string SesOzellikleri { get; set; }
        public string AltYazilari { get; set; }
        public string? AldigiOduller { get; set; }
        public string? BarkodNo { get; set; }
        public Tedarikci Tedarikci { get; set; }
        public decimal? Fiyat { get; set; }
        public DateTime EklemeTarihi { get; set; }
        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
    }
}
