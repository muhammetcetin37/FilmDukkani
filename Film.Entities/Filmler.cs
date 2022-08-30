namespace Film.Entities
{


    public class Filmler : BaseEntity
    {
        public string FilmAdi { get; set; }
        public string Aciklama { get; set; }
        public string Yonetmen { get; set; }
        public string Oyuncular { get; set; }
        public string? TeknikOzellikler { get; set; }
        public DateTime YapimYili { get; set; }
        public string? SesOzellikleri { get; set; }
        public string? AltYazilari { get; set; }
        public string AldigiOduller { get; set; }
        public string? BarkodNo { get; set; }
        public Tedarikci? Tedarikci { get; set; }
        public decimal Fiyat { get; set; }
        public DateTime EklemeTarihi { get; set; }
        public string KategoriAdi { get; set; }




    }
}
