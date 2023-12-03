namespace WinFormsApp13
{
 

    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LavenderBlush;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 600);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DeepPink;
            label1.Location = new Point(677, -7);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DeepPink;
            label2.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LavenderBlush;
            label2.Location = new Point(618, 105);
            label2.Name = "label2";
            label2.Size = new Size(137, 48);
            label2.TabIndex = 2;
            label2.Text = "PUAN=";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DeepPink;
            label3.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.LavenderBlush;
            label3.Location = new Point(747, 105);
            label3.Name = "label3";
            label3.Size = new Size(41, 48);
            label3.TabIndex = 3;
            label3.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DeepPink;
            label4.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.LavenderBlush;
            label4.Location = new Point(221, 628);
            label4.Name = "label4";
            label4.Size = new Size(134, 48);
            label4.TabIndex = 4;
            label4.Text = "BAŞLA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MidnightBlue;
            label5.Font = new Font("Comic Sans MS", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.LightCyan;
            label5.Location = new Point(581, 597);
            label5.Name = "label5";
            label5.Size = new Size(207, 84);
            label5.TabIndex = 5;
            label5.Text = "label5";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 700);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            ForeColor = Color.ForestGreen;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private System.Windows.Forms.Timer timer1;
        protected System.Windows.Forms.Panel panel1;

    }
}