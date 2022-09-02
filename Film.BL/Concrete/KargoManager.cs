using Film.BL.Abstract;
using Film.Entities;

namespace Film.BL.Concrete
{
    public class KargoManager : ManaBase<Kargo>, IKargoManager
    {
        public bool IsmiKontrolEt(string KargoAdi)
        {
            var sonuc = base.repo.GetAll(p => p.KargoAdi == KargoAdi);
            if (sonuc != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public override int Add(Kargo input)
        {
            if (!IsmiKontrolEt(input.KargoAdi))
                return base.Add(input);
            else
                return -1;
        }
    }
}

