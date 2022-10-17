using System;

namespace Encapsulation{
    class Program{
        public static void Main(string [] args){
            Ogrenci ogranci1= new Ogrenci();
            ogranci1.Isim="deneme";
            ogranci1.Soyisim="dene";
            ogranci1.No=12;
            ogranci1.Sinif=1;
            ogranci1.OgrenciBilgileriniGetir();
            ogranci1.SinifAtlat();
            ogranci1.OgrenciBilgileriniGetir();
            
        }


    }
    class Ogrenci{
        private string isim;
        private string soyisim;
        private int no;
        private int sinif;

        public string Isim{
            get{ return isim;}
            set {isim=value;}
        }
        public string Soyisim{
             get=> soyisim; set=>soyisim=value; }
        public int No{
             get=> no; set=>no=value;}

             public int Sinif{
                get =>sinif;
                set{
                    if(value<1){
                        Console.WriteLine("Sınıf en az 1 olabilir");
                        sinif=1;
                    }
                    else
                    sinif=value;
                }
             }
             public Ogrenci(string isim, string soyisim, int no, int sinif){
                Isim=isim;
                Soyisim=soyisim;
                No=no;
                Sinif=sinif;
             }
             public Ogrenci()
             {

             }
             public void OgrenciBilgileriniGetir()
             {
                Console.WriteLine("**********Ogrenci bilgileri*******");
                Console.WriteLine("Ogrenci adi: {0}",this.Isim);
                Console.WriteLine("Ogrenci soyadi: {0}",this.Soyisim);
                Console.WriteLine("Ogrenci no: {0}",this.No);
                Console.WriteLine("Ogrenci sınıfı: {0}",this.Sinif);
             }

             public void SinifAtlat()
             {
                this.Sinif= this.Sinif+1;
             }

             public void SinifDusur()
             {
                this.Sinif= this.Sinif-1;
             }
    }
}
