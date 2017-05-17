using System;
namespace WarGame
{
    public class DusmanAdapter:IDusman
    {
        IDusmanPlus dusmanPlus;
        IDusman dusman;
        public DusmanAdapter(string dusmanTuru)
        {
            if (dusmanTuru == "robot")
                dusmanPlus = new DusmanRobotu();
            else if (dusmanTuru == "tank")
                dusman = new DusmanTank();
        }

        public void DusmanAdi(string dusmanTuru, string dusmanAdi)
        {
            if(dusmanTuru == "robot")
                dusmanPlus.RobotIsim(dusmanTuru,dusmanAdi);
            if (dusmanTuru == "tank")
                dusman.DusmanAdi(dusmanTuru, dusmanAdi);
        }

        public void Hizlan(string dusmanTuru, bool hizli)
        {
            if (dusmanTuru == "robot")
                dusmanPlus.Yuru(dusmanTuru, hizli);
            if (dusmanTuru == "tank")
                dusman.Hizlan(dusmanTuru, hizli);
        }

        public void SilahKullan(string dusmanTuru, bool silah)
        {
            if (dusmanTuru == "robot")
                dusmanPlus.YumrukAt(dusmanTuru, silah);
            if (dusmanTuru == "tank")
                dusman.SilahKullan(dusmanTuru, silah);
        }
    }
}
