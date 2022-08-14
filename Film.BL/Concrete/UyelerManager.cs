using Film.BL.Abstract;
using Film.Entities;

namespace Film.BL.Concrete
{
    public class UyelerManager : ManaBase<Uyeler>, IUyelerManager
    {
        public bool EmailKontrolEt(string Email)
        {
            var sonuc = base.repo.GetAll(p => p.Email == Email);
            if (sonuc != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public override int Add(Uyeler input)
        {
            if (!EmailKontrolEt(input.Email))
                return base.Add(input);
            else
                return -1;
        }


        public bool PasswordKontrolEt(string Password)
        {
            var sonuc = base.repo.GetAll(p => p.Password == Password);
            if (sonuc != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
