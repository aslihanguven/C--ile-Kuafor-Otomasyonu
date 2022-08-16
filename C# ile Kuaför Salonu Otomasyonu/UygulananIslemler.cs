using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProje
{
    public class Islemler //Islemler sınıfı oluşturuldu.
    {
        //Değişkenler belirlenip , erişim belirleyiciler kullanılarak erişim sınırları belirlendi.
        public int musteri_no { get; set; } 
        public string sac_boyu { get; set; }
        public string kesim_modeli { get; set; }
        public string sac_rengi { get; set; }
        public bool manikur_pedikur { get; set; }
        public int boya_ucreti { get; set; } 
        public int kesim_ucreti { get; set; }
        public Islemler( string sac_boyu, string kesim_modeli, string sac_rengi, int boya_ucreti, int kesim_ucreti, bool manikur_pedikur) //Islemler adında parametreli geri dönüşlü metot kullanıldı.
        {
            //Nesnelerin referansları belirtildi.
            this.sac_boyu = sac_boyu;
            this.kesim_modeli = kesim_modeli;
            this.sac_rengi = sac_rengi;
            this.boya_ucreti = boya_ucreti;
            this.manikur_pedikur = manikur_pedikur;
            this.kesim_ucreti = kesim_ucreti;
        }

        public Islemler()
        {
        }

        public override string ToString() //Nesneler için istediğimiz değerleri yazdırabilmek için ToString kullanıldı.
        {
            return string.Format("Bakım İşlemleri: \n\tSaç Boyu : {0}\n\tKesim Modeli : {1}\n\tSaç Rengi: {2}\n\tManikür-Pedikür : {3} ", sac_boyu, kesim_modeli, sac_rengi, manikur_pedikur);
        }

    }
}


