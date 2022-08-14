using Film.Entities;

namespace Film.BL.Abstract
{
    public interface IUyelerManager : IManaBase<Uyeler>
    {
        bool EmailKontrolEt(string Email);
        bool PasswordKontrolEt(string Password);
    }
}
