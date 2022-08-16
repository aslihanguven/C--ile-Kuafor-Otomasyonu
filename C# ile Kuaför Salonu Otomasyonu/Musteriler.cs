using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProje
{
    public class Musteri //Müşteriler sınıfı oluşturuldu.
    {
        //Değişkenler belirlendi.
        private int yas;
        private long telNo = 0;
        private string ad;
        private string soyad;
        private DayOfWeek randevu;

        //Erişim belirleyiciler kullanılarak erişim sınırları belirlendi.
        public long TelNo
        {
            get { return telNo; }
            set { telNo = value; }
        }
        public DayOfWeek Randevu
        {
            get { return randevu; }
            set { randevu = value; }
        }
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public int Yas
        {
            get { return yas; }
            set { yas = value; }
        }

        public override string ToString() //Nesneler için istediğimiz değerleri yazdırabilmek için ToString kullanıldı.
        {
            return string.Format("Müşteriler: \n\tAd : {0}\n\t Soyad: {1}\n\tYas: {2}\n\tTel No: {3}\n\tRandevu: ", Ad, Soyad, Yas, TelNo, Randevu);
        }

    }
}