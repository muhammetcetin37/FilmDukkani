using Film.Entities;

namespace Film.BL.Abstract
{
    public interface IFilmlerManager : IManaBase<Filmler>
    {
        bool IsmiKontrolEt(string FilmAdi);
    }
}
