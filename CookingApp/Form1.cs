namespace CookingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        #region Async Methods
        public async Task YumurtalariKir()
        {
            await Task.Delay(500);
            AddLog("Yumurtalar Kýrýldý.");
            ButtonFlagGreen(1);
        }
        public async Task YumurtalariCirp()
        {
            await Task.Delay(500);
            AddLog($"Yumurtalar Çýrpýldý.");
            ButtonFlagGreen(2);
        }

        public async Task TuzEkle()
        {
            await Task.Delay(500);
            AddLog($"Tuz Eklendi.");
            ButtonFlagGreen(3);
        }

        public async Task OcagiAc()
        {
            await Task.Delay(500);
            AddLog($"Ocak Açýldý.");
            ButtonFlagGreen(4);
        }
        public async Task TavayiIsit()
        {
            await Task.Delay(1000);
            AddLog($"Tava Isýtýldý.");
            ButtonFlagGreen(5);
        }
        public async Task YagiDok()
        {
            await Task.Delay(500);
            AddLog($"Yað Döküldü.");
            ButtonFlagGreen(6);
        }
        public async Task YumurtayiEkle()
        {
            await Task.Delay(500);
            AddLog($"Yumurta Eklendi.");
            ButtonFlagGreen(7);
        }
        public async Task YemegiPisir()
        {
            await Task.Delay(1500);
            AddLog($"Yemek Piþirildi.");
            ButtonFlagGreen(8);
        }
        public async Task ServisEt()
        {
            await Task.Delay(1500);
            AddLog($"Yemek Servisi Yapýldý.");
            ButtonFlagGreen(9);
        }
        #endregion




        private void AddLog(string message)
        {
            listBox1.Items.Add(message);
        }

        private void ButtonFlagGreen(int step)
        {
            Button btn = pnlButtons.Controls[$"btnStep{step}"] as Button;

            btn.BackColor = Color.LimeGreen;
        }
    }
}
