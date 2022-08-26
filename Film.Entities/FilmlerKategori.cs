namespace Film.Entities
{
    public class FilmlerKategori : BaseEntity
    {
        public int FilmlerId { get; set; }
        public int KategoriId { get; set; }
        public int PaketId { get; set; }
        public int SepetId { get; set; }
    }
}
