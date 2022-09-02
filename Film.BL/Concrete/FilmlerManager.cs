using Film.BL.Abstract;
using Film.Entities;

namespace Film.BL.Concrete
{
    public class FilmlerManager : ManaBase<Filmler>, IFilmlerManager
    {
        public bool IsmiKontrolEt(string FilmAdi)
        {
            var sonuc = base.repo.GetAll(p => p.FilmAdi == FilmAdi);
            if (sonuc != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public override int Add(Filmler input)
        {
            if (!IsmiKontrolEt(input.FilmAdi))
                return base.Add(input);
            else
                return -1;
        }
    }
}
