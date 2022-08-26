namespace Film.Entities
{
    public class Paket : BaseEntity
    {
        public string UyelikModeli { get; set; }
        public string Degisim { get; set; }
        public int AylikFilmSayisi { get; set; }
        public decimal AylikUcret { get; set; }
    }
}
