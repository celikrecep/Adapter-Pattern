using System;
namespace WarGame
{
    public class DusmanRobotu : IDusmanPlus
    {
        public void RobotIsim(string dusmanTuru,string isim)
        {
            Console.WriteLine("Dusman " +dusmanTuru +"'a " +isim + " ismi verildi.");
        }

        public void YumrukAt(string dusmanTuru,bool silah)
        {
            if(silah==true)
                Console.WriteLine("Dusman "+ dusmanTuru + " yumruk atti.");
            else
                Console.WriteLine("Dusman " +dusmanTuru+ " tarafindan saldırı yok.");
        }

        public void Yuru(string dusmanTuru, bool yuru)
        {
            if(yuru == true)
                Console.WriteLine("Dusman " +dusmanTuru+ " ilerledi.");
            else
                Console.WriteLine("Dusman" +dusmanTuru+ "sabit.");
        }
    }
}
