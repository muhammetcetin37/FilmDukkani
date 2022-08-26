namespace Film.Entities
{
    public class Sepet : BaseEntity
    {
        public string FilmAdi { get; set; }
        public string KategoriAdi { get; set; }
        private DateTime _SepeteEklemeTarihi = DateTime.Now;

        public DateTime SepeteEklemeTarihi
        {
            get { return _SepeteEklemeTarihi; }
            set { _SepeteEklemeTarihi = value; }
        }
        public decimal Fiyat { get; set; }
    }
}
