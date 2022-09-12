namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz dizimi
            // class SinifAdi
            // {
            //      [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
            //      [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi])
            //      {
            //      // Metod Komutları
            //      }
            //}    
            
            //Erişim Belirleyiciler
            // * Public
            // * Private
            // * Internal
            // * ProtectedCalisan calisan1 = new Calisan();
            
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Kara";
            calisan1.No = 23425634;
            calisan1.Department = "İnsan Kaynakları";
            calisan1.CalisanBilgileri();
            Console.WriteLine("*****************");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 25646789;
            calisan2.Department = "Satın Alma";

            calisan2.CalisanBilgileri();
        }
    }
}


class Calisan   
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Department;

    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışanın Adı: {0}", Ad);
        Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
        Console.WriteLine("Çalışanın Numarası {0}", No);
        Console.WriteLine("Çalışanın Departmanı {0}", Department);     
    }
}