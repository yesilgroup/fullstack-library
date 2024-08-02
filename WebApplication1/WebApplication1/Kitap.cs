namespace WebApplication1
{
    public class Kitap
    {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public string Yazar { get; set; }
        public string BasimYili { get; set; }
        public string Yayinevi { get; set; }
        public bool OduncAlindiMi { get; set; }

        public Kitap(int kitapID, string kitapAdi, string yazar, string basimYili, string yayinevi, bool oduncAlindiMi)
        {
            this.KitapID = kitapID;
            this.KitapAdi = kitapAdi;
            this.Yazar = yazar;
            this.BasimYili = basimYili;
            this.Yayinevi = yayinevi;
            this.OduncAlindiMi = oduncAlindiMi;
        }
    }
}
