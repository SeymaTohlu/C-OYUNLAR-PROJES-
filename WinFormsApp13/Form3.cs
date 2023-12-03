namespace WinFormsApp13
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            label4.Click += label4_Click;
        }

        Panel? parca;
        Panel elma = new Panel();
        List<Panel> yilan = new List<Panel>();
        string yon = "sağ";

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object? sender, EventArgs e)
        {
            if (sender != null)
            { 
                label3.Text = "0";
            paneliTemizle();
            parca = new Panel();
            parca.Location = new Point(200, 200);
            parca.Size = new Size(20, 20);
            parca.BackColor = Color.Gray;
            yilan.Add(parca);
            panel1.Controls.Add(yilan[0]);
            timer1.Start();
            elmaOluştur();
            this.KeyPreview = true;
            MoveSnake();
            }
        }
       

        void carpismaKontrol()
        {
            for (int i = 2; i < yilan.Count; i++)
            {
                if (yilan[0].Location == yilan[i].Location)
                {
                    label5.Visible = true;
                    label5.Text = "KAYBETTİNİZ.";
                    timer1.Stop();
                }
            }
        }

        void paneliTemizle()
        {
            panel1.Controls.Clear();
            yilan.Clear();
            label5.Visible = false;
        }

        void puanKontrol()
        {
            int puan = int.Parse(label3.Text);
            if (puan > 500)
            {
                label5.Text = "KAZANDINIZ";
                label5.Visible = true;
                timer1.Stop();
            }
        }
        private void MoveSnake()
        {
            int locX = yilan[0].Location.X;
            int locY = yilan[0].Location.Y;

            elmaYediMi();
            hareket();
            carpismaKontrol();
            puanKontrol();

            // ... (geri kalan kod değişmeden kalır)
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int locX = yilan[0].Location.X;
            int locY = yilan[0].Location.Y;

            elmaYediMi();
            hareket();
            carpismaKontrol();
            puanKontrol();
            MoveSnake();
            if (yon == "sağ")
            {
                if (locX < 580)
                {
                    locX += 20;
                }
                else
                {
                    locX = 0;
                }
            }

            if (yon == "sol")
            {
                if (locX > 0)
                {
                    locX -= 20;
                }
                else
                {
                    locX = 580;
                }
            }

            if (yon == "aşağı")
            {
                if (locY < 580)
                {
                    locY += 20;
                }
                else
                {
                    locY = 0;
                }
            }

            if (yon == "yukarı")
            {
                if (locY > 0)
                {
                    locY -= 20;
                }
                else
                {
                    locY = 580;
                }
            }

            yilan[0].Location = new Point(locX, locY);
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right && yon != "sol")
                yon = "sağ";
            if (e.KeyCode == Keys.Left && yon != "sağ")
                yon = "sol";
            if (e.KeyCode == Keys.Up && yon != "aşağı")
                yon = "yukarı";
            if (e.KeyCode == Keys.Down && yon != "yukarı")
                yon = "aşağı";
        }

        void elmaOluştur()
        {
            Random rnd = new Random();
            int elmaX, elmaY;
            elmaX = rnd.Next(580);
            elmaY = rnd.Next(580);
            elmaX -= elmaX % 20;
            elmaY -= elmaY % 20;
            elma.Size = new Size(20, 20);
            elma.BackColor = Color.Red;
            elma.Location = new Point(elmaX, elmaY);
            panel1.Controls.Add(elma);
        }

        void elmaYediMi()
        {
            int puan = int.Parse(label3.Text);
            if (yilan[0].Location == elma.Location)
            {
                panel1.Controls.Remove(elma);
                puan += 50;
                label3.Text = puan.ToString();
                elmaOluştur();
                parcaEkle(); // Yılanın bir parça daha eklenmesi
            }
        }

        void parcaEkle()
        {
            Panel ekParca = new Panel();
            ekParca.Size = new Size(20, 20);
            ekParca.BackColor = Color.Gray;
            yilan.Add(ekParca);
            panel1.Controls.Add(ekParca);
        }

        void hareket()
        {
            for (int i = yilan.Count - 1; i > 0; i--)
            {
                yilan[i].Location = yilan[i - 1].Location;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
