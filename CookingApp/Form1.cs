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
        1-Yumurtalar� K�r
        2-Yumurtalar� ��rp
        3-Tuz Ekle
        4-Oca�� A�
        5-Tavay� Is�t
        6-Ya�� D�k
        7-Yumurtay� Ekle
        8-Pi�ir 
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
            AddLog("Yumurtalar K�r�ld�.");
            ButtonFlagGreen(1);
        }
        public async Task YumurtalariCirp()
        {
            await Task.Delay(500);
            AddLog($"Yumurtalar ��rp�ld�.");
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
            AddLog($"Ocak A��ld�.");
            ButtonFlagGreen(4);
        }
        public async Task TavayiIsit()
        {
            await Task.Delay(1000);
            AddLog($"Tava Is�t�ld�.");
            ButtonFlagGreen(5);
        }
        public async Task YagiDok()
        {
            await Task.Delay(500);
            AddLog($"Ya� D�k�ld�.");
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
            AddLog($"Yemek Pi�irildi.");
            ButtonFlagGreen(8);
        }
        public async Task ServisEt()
        {
            await Task.Delay(1500);
            AddLog($"Yemek Servisi Yap�ld�.");
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
