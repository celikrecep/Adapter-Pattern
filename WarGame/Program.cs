using System;

namespace WarGame
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DusmanCreate dusman = new DusmanCreate();
            dusman.DusmanAdi("tank","mehmet");
            dusman.DusmanAdi("robot", "ahmet");
            dusman.Hizlan("robot",true);
            dusman.Hizlan("tank", false);
            dusman.SilahKullan("robot", false);
            dusman.SilahKullan("tank",true);

        }
    }
}
