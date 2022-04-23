namespace veriYapıları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AramaYap_Click(object sender, EventArgs e)
        {

            Baslama();

            veriTut();

        }
        private int Baslama()//Arama yap butonuna tıkladığımızda başlama zamanını gösterir
        {
            string s;
            DateTime dt = DateTime.Now;
            s = "arama başlama zamanı -" + dt.ToLongTimeString();
            return ZamanBilgisi.Items.Add(s);

        }

        private void AramaSon_Click(object sender, EventArgs e)
        {

            Bitir();
            veriTut();
         
        }
        int Bitir() //Arama sonlandırma butonuna tıkladığımızda zamanını gösterir
        {
            string s;
            DateTime dt = DateTime.Now;
            s = "arama sonlanma zamanı =" + dt.ToLongTimeString();
           return ZamanBilgisi.Items.Add(s);
        }

        private void TemsilciSec_Click(object sender, EventArgs e)
        {
            int eSayisi = checkedListBox1.CheckedItems.Count;
            for (int i = 0; i < eSayisi; i++)
            {
                ZamanBilgisi.Items.Add(checkedListBox1.CheckedItems[i]);
            }
        }
        public void veriTut()//Zaman bilgisi listboxundaki verileri dizi tipinde tutulacak
        {
            string[] veri1 = new string[ZamanBilgisi.Items.Count];
            for (int i = 0; i < ZamanBilgisi.Items.Count; i++)
            {
               veri1[i]=ZamanBilgisi.Items[i].ToString();
            }
            List<string> veri2 = new List<string>();
            foreach (var item in ZamanBilgisi.Items)
            {
                veri2.Add(item.ToString());
            }
         
        }
        public void dizitut()//Zaman bilgilerini Cağrı bilgilerinde  dizi tipinde tutacak
        {
          string[] cagriBilg=new string[ZamanBilgisi.Items.Count];
            for(int i=0; i<ZamanBilgisi.Items.Count; i++)
            {
                cagriBilg[i]=ZamanBilgisi.Items[i].ToString();
            }
        }

        private void CagriBilgisiGetir_Click(object sender, EventArgs e)
        {
            QueueBil q1 =new QueueBil();
            q1.Insert(ZamanBilgisi.Text); //Zaman bilgisi listboxundaki verileri kuyruğa ekledi
            Sirala();
            GunlukTutum();

        }

        private void KelimeBul_Click(object sender, EventArgs e)
        {

            //Kelime Arama Algoritması

            string[] kelime=textBox1.Text.Split('\u002C');
           
            string cagriRapor;
            List<string> kelimeList = new List<string>();
            
            for(int i=0; i<kelime.Length;i++)
            {
                if (kelimeList.Contains(kelime[i]) == true)
                {
                    kelimeList.Add(kelime[i]);
                }
            }
            foreach(string k in kelimeList)
            {
                int sayac = 0;
                for(int i=0; i < kelime.Length; i++)
                {
                    if (kelime[i] == k)
                    {
                        sayac++;
                    }
                }
                AramaSonucu.Items.Add(k+">>"+sayac+"adet");
            }

            
            
        }
        private void Sirala()//Sıralama Algoritması
        {
            int[] cagriId = new int[100];
            int temp = 0;

            for (int i = 0; i < 100; i++)
            {
                for (int j = i; j < 100; j++)
                {
                    if (cagriId[i] > cagriId[j])
                    {
                        temp = cagriId[j];
                        cagriId[j] = cagriId[i];
                        cagriId[i] = temp;
                    }
                }
            }
            foreach (int i in cagriId)
            {
                CagriBilgisi.Items.Add(i);
            }
        }

        private void GunlukTutum()//Çağrı bilgileri 1 günü doldurdukça silinir
        {

            QueueBil q2=new QueueBil();

            DateTime thisDay = DateTime.Today;
             if(thisDay > DateTime.Today)
            {
                q2.Remove();

            }
        }

    }
}