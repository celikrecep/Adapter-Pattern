using System;
namespace WarGame
{
    public class DusmanCreate : IDusman
    {
		DusmanAdapter dusmanAdapter;
        public void DusmanAdi(string dusmanTuru, string dusmanAdi)
        {
            
                dusmanAdapter = new DusmanAdapter(dusmanTuru);
                dusmanAdapter.DusmanAdi(dusmanTuru,dusmanAdi);
           
        }

        public void Hizlan(string dusmanTuru, bool hizli)
        {
            dusmanAdapter = new DusmanAdapter(dusmanTuru);
            dusmanAdapter.Hizlan(dusmanTuru,hizli);

        }

        public void SilahKullan(string dusmanTuru, bool silah)
        {
            dusmanAdapter = new DusmanAdapter(dusmanTuru);
            dusmanAdapter.SilahKullan(dusmanTuru,silah);
        }
    }
}
