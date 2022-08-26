using Film.Entities;

namespace FİlmMvc.Areas.Uye.Models
{
    public class Kaydet
    {
        private List<Kaydedilen> _kaydedilens = new List<Kaydedilen>();
        public List<Kaydedilen> Kaydedilens
        {
            get { return _kaydedilens; }
        }
        public void AddFilmler(Filmler filmler, int adet)
        {
            var film = _kaydedilens.FirstOrDefault(i => i.Filmler.Id == filmler.Id);
            if (film == null)
            {
                _kaydedilens.Add(new Kaydedilen() { Filmler = filmler, Adet = adet });
            }
            else
            {
                film.Adet += adet;
            }
        }
        public void DeleteFilmler(Filmler filmler)
        {
            _kaydedilens.RemoveAll(i => i.Filmler.Id == filmler.Id);
        }
        public decimal Total()
        {
            return _kaydedilens.Sum(i => i.Filmler.Fiyat * i.Adet);
        }
        public void Clear()
        {
            _kaydedilens.Clear();
        }
    }
    public class Kaydedilen
    {
        public Filmler Filmler { get; set; }
        public int Adet { get; set; }
    }
}
