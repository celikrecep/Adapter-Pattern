using System;
namespace WarGame
{
    public class DusmanTank : IDusman
    {
        
       
        public void DusmanAdi(string dusmanTuru, string dusmanAdi)
        {
            Console.WriteLine("Dusman " +dusmanTuru+ "'a " +dusmanAdi+ " ismi verildi.");
        }

        public void Hizlan(string dusmanTuru, bool hizli)
        {
            if(hizli ==true)
                Console.WriteLine("Dusman " +dusmanTuru+ " hizli.");
            else
                Console.WriteLine("Dusman " +dusmanTuru+ " yavas.");
        }

        public void SilahKullan(string dusmanTuru, bool silah)
        {
            if(silah==true)
                Console.WriteLine("Dusman " +dusmanTuru+ " ates etti.");
            else
                Console.WriteLine("Dusman" +dusmanTuru+ " tarafindan saldiri yok.");
        }
    }
}
