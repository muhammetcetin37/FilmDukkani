namespace Film.Entities
{
    public class Kategori : BaseEntity
    {

        public string KategoriAdi { get; set; }
        public string Aciklama { get; set; }
        public IList<Filmler> filmler { get; set; }
    }
}
