using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

//JSON kullanabilmek için Newtonsoft.Json ve System.IO kütüphaneleri kullanıldı.


namespace FinalProje
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KUAFÖR SALONU:\n");
            Islemler();
            Console.ReadLine();
        }
        public static void Islemler() //Oluşturmuş olduğumuz Islemler metodu çağırıldı.
        {
            List<Islemler> IslemListesi = new List<Islemler>(); //Islemler metodundan IslemListesi adında yeni bir liste oluşturuldu.

            Islemler islem1 = new Islemler() //Islemler listesine yeni bir işlem oluşturuldu.
            {
                //Değişkenlere değerler atandı.
                sac_boyu = "kısa",
                kesim_modeli = "kahkül",
                sac_rengi = "siyah",
                boya_ucreti = 240,
                kesim_ucreti = 70,
                manikur_pedikur = true

            };
            IslemListesi.Add(islem1); //Listeye ekleme işlemi yapıldı.

            Islemler islem2 = new Islemler() //Islemler listesine yeni bir işlem oluşturuldu.
            {
                sac_boyu = "uzun",
                kesim_modeli = "V kesim",
                sac_rengi = "sarı",
                boya_ucreti = 280,
                kesim_ucreti = 90,
                manikur_pedikur = false

            };
            IslemListesi.Add(islem2);//Islemler listesine yeni bir işlem eklendi.

            Islemler islem3 = new Islemler() 
            {
                sac_boyu = "orta",
                kesim_modeli = "Oval Kesim",
                sac_rengi = "Kızıl",
                boya_ucreti = 310,
                kesim_ucreti = 80,
                manikur_pedikur = true
            };
            IslemListesi.Add(islem3);
            Islemler islem4 = new Islemler()
            {
                sac_boyu = "uzun",
                kesim_modeli = "Küt kesim",
                sac_rengi = "Sıcak Çikolata",
                boya_ucreti = 320,
                kesim_ucreti = 90,
                manikur_pedikur = true
            };
            IslemListesi.Add(islem4);

            if (Directory.Exists("c:\\Json\\")) //Klasör mevcutsa işlem yapılmıyor.
            {
              

            }
            else //Klasör mevcut değilse oluşturuluyor.
            {
                Directory.CreateDirectory("c:\\Json\\");
            }

            //JSON İşlemleri yapıldı.
            string IslemlerJson = JsonConvert.SerializeObject(IslemListesi); 

            File.WriteAllText("c:\\Json\\Islemler.json", IslemlerJson);


            for (int i = 0; i < IslemListesi.Count; i++)
            {
                string json = JsonConvert.SerializeObject(IslemListesi);
                Console.WriteLine(json);                            //konsolda json formatında yazdırma
                Console.WriteLine(IslemListesi[i]); //işlem listesi ekrana yazdırıldı
                
            }
           
            List<Musteri> Musteri = new List<Musteri>(); //Müşteri metodundan yeni bir Müşteri listesi oluşturuldu.

            Musteri musteri1 = new Musteri() //Musteri metodundan musteri1 nesnesi oluşturuldu.
            {
                Ad = "Merve",
                Soyad = "Güven",
                Yas = 17,
                TelNo = 05055052222,
                Randevu = DayOfWeek.Thursday,

            };
            Musteri.Add(musteri1); //Listeye ekleme işlemi yapıldı.

            Musteri musteri2 = new Musteri()
            {
                Ad = "Aslıhan",
                Soyad = "Güven",
                Yas = 21,
                TelNo = 05052002020,
                Randevu = DayOfWeek.Monday,

            };
            Musteri.Add(musteri2);

            Musteri musteri3 = new Musteri()
            {
                Ad = "Neslihan",
                Soyad = "Güven",
                Yas = 27,
                TelNo = 05004004040,
                Randevu = DayOfWeek.Sunday,

            };
            Musteri.Add(musteri3);

            Musteri musteri4 = new Musteri()
            {
                Ad = "Rahşan",
                Soyad = "Güven",
                Yas = 46,
                TelNo = 05005005050,
                Randevu = DayOfWeek.Wednesday,
            };
            Musteri.Add(musteri4);

            //JSON işlemleri yapıldı.

            string MusterilerJson = JsonConvert.SerializeObject(Musteri);

            File.WriteAllText("c:\\Json\\Musteri.json", MusterilerJson);


            for (int i = 0; i < Musteri.Count; i++)
            {

                Console.WriteLine(Musteri[i]); //For döngüsü oluşturularak ekrana yazdırma işlemi yapıldı.
               
            }

            Console.ReadLine();

            List<Odeme> Odemelerr = new List<Odeme>(); //Odeme metodundan yeni bir liste oluşturuldu.

            Odeme odeme1 = new Odeme()
            {
                islem_no = 1,
                musteri_isim = "Merve",
                musteri_soyisim = "Güven",
                randevu_tarihi=DayOfWeek.Thursday,
                fiyat=310
                 
            };
            Odemelerr.Add(odeme1);
            Odeme odeme2 = new Odeme()
            {
                islem_no = 2,
                musteri_isim = "Aslıhan",
                musteri_soyisim = "Güven",
                randevu_tarihi = DayOfWeek.Monday,
                fiyat = 370
            };
            Odemelerr.Add(odeme2);
            Odeme odeme3 = new Odeme()
            {
                islem_no = 3,
                musteri_isim = "Neslihan",
                musteri_soyisim = "Güven",
                randevu_tarihi = DayOfWeek.Sunday,
                fiyat = 390
            };
            Odemelerr.Add(odeme3);

            //JSON İşlemleri yapıldı.
            string OdemelerJson = JsonConvert.SerializeObject(Odemelerr);

            File.WriteAllText("c:\\Json\\Odeme.json", OdemelerJson);

            for (int i = 0; i < Odemelerr.Count; i++)
            {
                Console.WriteLine(Odemelerr[i]);
            }

            Console.ReadLine();
        }
    }

}           
   
