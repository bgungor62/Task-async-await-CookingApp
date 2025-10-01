using System.Diagnostics;
using static System.Reflection.Metadata.BlobBuilder;

namespace CookingApp
{
    public partial class Form1 : Form
    {

        System.Windows.Forms.Timer timer;
        public Form1()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Tick += (sender, e) =>
            {
                label1.Text = DateTime.Now.ToString("HH:mm:ss");
            };

            timer.Interval = 1000;
            timer.Start();
        }

        /*
         Omlet tarifi
        1-Yumurtalarý Kýr
        2-Yumurtalarý Çýrp
        3-Tuz Ekle
        4-Ocaðý Aç
        5-Tavayý Isýt
        6-Yaðý Dök
        7-Yumurtayý Ekle
        8-Piþir 
        9-Servis Et
        
        Omelet Recipe
1- Break the Eggs
2- Whisk the Eggs
3- Add Salt
4- Turn Up the Heat
5- Heat the Pan
6- Add the Oil
7- Add the Eggs
8- Cook
9- Serve
         */
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        #region Async
        public async Task YumurtalariKirAsync()
        {
            await Task.Delay(500);
            AddLog("Yumurtalar Kýrýldý.");
            ButtonFlagGreen(1);
        }
        public async Task YumurtalariCirpAsync()
        {
            await Task.Delay(750);
            AddLog($"Yumurtalar Çýrpýldý.");
            ButtonFlagGreen(2);
        }
        public async Task TuzEkleAsync()
        {
            await Task.Delay(500);
            AddLog($"Tuz Eklendi.");
            ButtonFlagGreen(3);
        }
        public async Task OcagiAcAsync()
        {
            await Task.Delay(500);
            AddLog($"Ocak Açýldý.");
            ButtonFlagGreen(4);
        }
        public async Task TavayiIsitAsync()
        {
            await Task.Delay(1000);
            AddLog($"Tava Isýtýldý.");
            ButtonFlagGreen(5);
        }
        public async Task YagiDokAsync()
        {
            await Task.Delay(500);
            AddLog($"Yað Döküldü.");
            ButtonFlagGreen(6);
        }
        public async Task YumurtayiEkleAsync()
        {
            await Task.Delay(500);
            AddLog($"Yumurta Eklendi.");
            ButtonFlagGreen(7);
        }
        public async Task YemegiPisirAsync()
        {
            await Task.Delay(1500);
            AddLog($"Yemek Piþirildi.");
            ButtonFlagGreen(8);
        }
        public async Task ServisEtAsync()
        {
            await Task.Delay(1000);
            AddLog($"Yemek Servisi Yapýldý.");
            ButtonFlagGreen(9);
        }
        #endregion




        private void AddLog(string message)
        {
            if (!string.IsNullOrEmpty(message))
                message = $"[{DateTime.Now:dd:MM.yyyy HH:mm:ss}] - {message}";

            listBox1.Items.Add(message);
            listBox1.TopIndex = listBox1.Items.Count - 1; // Locate the last row
        }

        private void ButtonFlagGreen(int step)
        {
            Button btn = pnlButtons.Controls[$"btnStep{step}"] as Button;

            btn.BackColor = Color.LimeGreen;
        }

        //sync
        private void btnStartCooking_Click(object sender, EventArgs e)
        {
            uiSetDefault();
            var sw = Stopwatch.StartNew();

            YumurtalariKir();
            YumurtalariCirp();
            TuzEkle();
            OcagiAc();
            TavayiIsit();
            YagiDok();
            YumurtayiEkle();
            YemegiPisir();
            ServisEt();

            sw.Stop();
            AddLog("");
            AddLog($"Toplam Yemek Piþirme Süresi:{sw.ElapsedMilliseconds:0} MS");
        }

        private void uiSetDefault()
        {
            foreach (Control control in pnlButtons.Controls)
            {
                if (control is Button btn)
                    btn.BackColor = SystemColors.Control;
            }
            pnlButtons.Update();
            listBox1.Items.Clear();
        }

        //butonu be metodlarý da async yaptýk
        private async void btnStartCookingAsync_Click(object sender, EventArgs e)
        {
            uiSetDefault();
            var sw = Stopwatch.StartNew();

            await YumurtalariKirAsync();
            await YumurtalariCirpAsync();
            await TuzEkleAsync();
            await OcagiAcAsync();
            await TavayiIsitAsync();
            await YagiDokAsync();
            await YumurtayiEkleAsync();
            await YemegiPisirAsync();
            await ServisEtAsync();

            sw.Stop();
            AddLog("");
            AddLog($"Toplam Yemek Piþirme Süresi:{sw.ElapsedMilliseconds:0} MS");
        }


        #region sync
        public void YumurtalariKir()
        {
            Task.Delay(500).Wait();
            AddLog("Yumurtalar Kýrýldý");
            ButtonFlagGreen(1);
        }

        public void YumurtalariCirp()
        {
            Task.Delay(750).Wait();
            AddLog("Yumurtalar Çýrpýldý");
            ButtonFlagGreen(2);
        }

        public void TuzEkle()
        {
            Task.Delay(200).Wait();
            AddLog("Tuz Eklendi");
            ButtonFlagGreen(3);
        }

        public void OcagiAc()
        {
            Task.Delay(500).Wait();
            AddLog("Ocak Açýldý");
            ButtonFlagGreen(4);
        }

        public void TavayiIsit()
        {
            Task.Delay(1000).Wait();
            AddLog("Tava Isýndý");
            ButtonFlagGreen(5);
        }

        public void YagiDok()
        {
            Task.Delay(750).Wait();
            AddLog("Yað Tavaya Döküldü");
            ButtonFlagGreen(6);
        }

        public void YumurtayiEkle()
        {
            Task.Delay(750).Wait();
            AddLog("Yumurtalar Tavaya Döküldü");
            ButtonFlagGreen(7);
        }

        public void YemegiPisir()
        {
            Task.Delay(2000).Wait();
            AddLog("Yumurtalar Piþti");
            ButtonFlagGreen(8);
        }

        public void ServisEt()
        {
            Task.Delay(750).Wait();
            AddLog("Yumurtalar Servis Edildi");
            ButtonFlagGreen(9);
        }
        #endregion sync
    }
}
