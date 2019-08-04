namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] sehirler = { "İstanbul", "İzmir", "Bursa", "Ankara", "Eskişehir", "Antalya", "Konya", "Trabzon", "Sivas", "Mardin", "Bursa" };//string tipinde sehirler adında bir dizi tanımladım. Şehir bilgilerini içrise tanımladım
        private void brnOrnek1_Click(object sender, EventArgs e)
        {
          
            Array.Clear(sehirler, 4, 2);
            MessageBox.Show("Silinen Eleman: " + sehirler[4]);
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
       
            string[] geciciDizi = new string[4];

            //1.Kullanımı:
            Array.Copy(sehirler, geciciDizi, 3);
            MessageBox.Show("Kopyalanan Eleman: " + geciciDizi[1]);
           

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
           
            int arananIndex = Array.IndexOf(sehirler, "Bursa");
            MessageBox.Show("Aradığınız kelimenin indexsi: " + arananIndex);
        }


        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            int arananIndex = Array.LastIndexOf(sehirler, "Bursa");
            MessageBox.Show("Aradığınız kelimenin indexsi: " + arananIndex);
        }

        private void btnOrnek5_Click(object sender, EventArgs e)
        {
         

            Array.Sort(sehirler);
            MessageBox.Show(sehirler[1]);
        }

        private void btnOrnek6_Click(object sender, EventArgs e)
        {
            
            Array.Resize(ref sehirler, 23);

           
            Array.Resize<string>(ref sehirler, 23);
        }

        private void btnOrnek7_Click(object sender, EventArgs e)
        {
            Array.Reverse(sehirler);
            MessageBox.Show(sehirler[0]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
}