namespace Film.Entities
{
    public enum AdresTip
    {
        Ev,
        İs,
        Yazlik,
        Diger
    }

    public class Adres : BaseEntity
    {
        public int Id { get; set; }
        public int SehirId { get; set; }
        public int IlceId { get; set; }
        public string CaddeSokak { get; set; }
        public int DısKapiNo { get; set; }
        public int IcKapiNo { get; set; }

    }
}
