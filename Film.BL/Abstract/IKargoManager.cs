﻿using Film.Entities;

namespace Film.BL.Abstract
{
    public interface IKargoManager : IManaBase<Kargo>
    {
        bool IsmiKontrolEt(string KargoAdi);
    }
}
