using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProje
{
    class Odeme //ödeme sınıfı oluşturuldu
    {
        //Değişkenler belirlenip , erişim belirleyiciler kullanılarak erişim sınırları belirlendi.
        public DayOfWeek randevu_tarihi { get; set; }
        public string musteri_isim { get; set; }
        public string musteri_soyisim { get; set; }
        public int islem_no { get; set; }
        public int fiyat { get; set; }
       
        public Odeme(int islem_no, int fiyat, DayOfWeek randevu_tarihi, string musteri_isim, string musteri_soyisim) //Odeme adında parametreli geri dönüşlü metot oluşturuldu.
        {
            //Nesnelerin referansları belirtildi.
            this.randevu_tarihi = randevu_tarihi;
            this.musteri_isim = musteri_isim;
            this.musteri_soyisim = musteri_soyisim;
            this.islem_no = islem_no;
            this.fiyat = fiyat;
            
        }
        public Odeme()
        { 
        }

        public override string ToString() //Nesneler için istediğimiz değeri yazdırabilmek için ToString() kullanıldı.
        {
            return string.Format("Odeme Bilgileri: \n\tAd : {0}\n\t Soyad: {1}\n\tİşlem No: {2}\n\tRandevu Tarihi: {3}\n\tÖdeme: ", musteri_isim, musteri_soyisim, islem_no, randevu_tarihi, fiyat);
        }
    }
}

