using System;
namespace WarGame
{
    public interface IDusman
    {
        void SilahKullan(string dusmanTuru, bool silah);
        void Hizlan(string dusmanTuru ,bool hizli);
        void DusmanAdi(string dusmanTuru, string dusmanAdi);
    }
}
