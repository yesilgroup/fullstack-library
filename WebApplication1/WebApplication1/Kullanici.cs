namespace WebApplication1
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Eposta { get; set; }
        public string Sifre { get; set; }
        public DateTime KayitTarihi { get; set; } = DateTime.Now;

        public Kullanici(int kullaniciID, string ad, string soyad, string email, string sifre,DateTime kayitTarihi)
        {
            this.Id = kullaniciID;
            this.Ad = ad;
            this.Soyad = soyad;
            this.Eposta = email;
            this.Sifre = sifre;
            this.KayitTarihi = kayitTarihi;
        }
    }
}
