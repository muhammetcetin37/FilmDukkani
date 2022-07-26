namespace Film.Entities
{
    public class Tedarikci : BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Gsm { get; set; }
        public string? Email { get; set; }
        public string Adres { get; set; }
    }
}
