namespace Film.Entities
{
    public class FilmlerKategori : BaseEntity
    {
        public int FilmId { get; set; }
        public int KategoriId { get; set; }
        public int PaketId { get; set; }
    }
}
