using System;
using System.Windows.Forms;

namespace WinFormsApp13
{
    public partial class Form2 : Form
    {
        private int sure = 15;
        private DialogResult deger;

        public Form2()
        {
            InitializeComponent();
            label2.Text = sure.ToString();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("KAYBETTİNİZ.", "KENARA DEĞDİNİZ.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.Close();
        }
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("KAYBETTİNİZ.", "KENARA DEĞDİNİZ.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.Close();
        }
        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("KAYBETTİNİZ.", "KENARA DEĞDİNİZ.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.Close();
        }
        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("KAYBETTİNİZ.", "KENARA DEĞDİNİZ.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.Close();
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("KAYBETTİNİZ.", "KENARA DEĞDİNİZ.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.Close();
        }
        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("KAYBETTİNİZ.", "KENARA DEĞDİNİZ.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.Close();
        }
        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("KAYBETTİNİZ.", "KENARA DEĞDİNİZ.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.Close();
        }
        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("KAYBETTİNİZ.", "KENARA DEĞDİNİZ.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.Close();
        }
        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("KAYBETTİNİZ.", "KENARA DEĞDİNİZ.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.Close();
        }
        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("KAYBETTİNİZ.", "KENARA DEĞDİNİZ.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.Close();
        }
        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("KAYBETTİNİZ.", "KENARA DEĞDİNİZ.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.Close();
        }
        private void pictureBox12_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("KAYBETTİNİZ.", "KENARA DEĞDİNİZ.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.Close();
        }
        private void pictureBox13_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("KAYBETTİNİZ.", "KENARA DEĞDİNİZ.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.Close();
        }
        private void pictureBox14_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("KAYBETTİNİZ.", "KENARA DEĞDİNİZ.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.Close();
        }
        private void pictureBox15_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("KAYBETTİNİZ.", "KENARA DEĞDİNİZ.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.Close();
        }
        private void pictureBox16_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("KAYBETTİNİZ.", "KENARA DEĞDİNİZ.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.Close();
        }
        private void pictureBox17_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("KAYBETTİNİZ.", "KENARA DEĞDİNİZ.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.Close();
        }
        

        private void Form2_MouseEnter(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sure > 0)
            {
                sure--;
                label2.Text = sure.ToString();
            }
            else
            {
                timer1.Enabled = false;
                deger = MessageBox.Show("SÜRE BİTTİ.", "TEKRAR OYNAMAK İSTER MİSİNİZ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (deger == DialogResult.Yes)
                {
                    sure = 15;
                    label2.Text = sure.ToString();
                    timer1.Enabled = true;
                }
                else if (deger == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("KAZANDINIZ.", "Tebrikler.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            timer1.Enabled = false;
        }
    }
}

