namespace Black_Jack
{
    partial class Form1 : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_carta_1 = new Label();
            lbl_pontos_1 = new Label();
            lbl_carta_2 = new Label();
            lbl_pontos_2 = new Label();
            btn_passar_vez = new Button();
            btn_pegar_carta = new Button();
            img_carta_1 = new PictureBox();
            img_carta_2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)img_carta_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_carta_2).BeginInit();
            SuspendLayout();
            // 
            // lbl_carta_1
            // 
            lbl_carta_1.AutoSize = true;
            lbl_carta_1.ForeColor = SystemColors.ButtonHighlight;
            lbl_carta_1.Location = new Point(50, 278);
            lbl_carta_1.Name = "lbl_carta_1";
            lbl_carta_1.Size = new Size(96, 15);
            lbl_carta_1.TabIndex = 0;
            lbl_carta_1.Text = "Mão do Jogador:";
            lbl_carta_1.Click += label1_Click;
            // 
            // lbl_pontos_1
            // 
            lbl_pontos_1.AutoSize = true;
            lbl_pontos_1.ForeColor = SystemColors.ButtonHighlight;
            lbl_pontos_1.Location = new Point(50, 325);
            lbl_pontos_1.Name = "lbl_pontos_1";
            lbl_pontos_1.Size = new Size(47, 15);
            lbl_pontos_1.TabIndex = 1;
            lbl_pontos_1.Text = "Pontos:";
            lbl_pontos_1.Click += playerScoreLabel_Click;
            // 
            // lbl_carta_2
            // 
            lbl_carta_2.AutoSize = true;
            lbl_carta_2.ForeColor = SystemColors.ButtonHighlight;
            lbl_carta_2.Location = new Point(401, 278);
            lbl_carta_2.Name = "lbl_carta_2";
            lbl_carta_2.Size = new Size(105, 15);
            lbl_carta_2.TabIndex = 2;
            lbl_carta_2.Text = "Mão do Jogador 2:";
            lbl_carta_2.Click += lbl_carta_2_Click;
            // 
            // lbl_pontos_2
            // 
            lbl_pontos_2.AutoSize = true;
            lbl_pontos_2.ForeColor = SystemColors.ButtonHighlight;
            lbl_pontos_2.Location = new Point(401, 325);
            lbl_pontos_2.Name = "lbl_pontos_2";
            lbl_pontos_2.Size = new Size(47, 15);
            lbl_pontos_2.TabIndex = 3;
            lbl_pontos_2.Text = "Pontos:";
            // 
            // btn_passar_vez
            // 
            btn_passar_vez.Location = new Point(164, 378);
            btn_passar_vez.Name = "btn_passar_vez";
            btn_passar_vez.Size = new Size(106, 38);
            btn_passar_vez.TabIndex = 4;
            btn_passar_vez.Text = "Passar Vez";
            btn_passar_vez.UseVisualStyleBackColor = true;
            btn_passar_vez.Click += btn_passar_vez_Click;
            // 
            // btn_pegar_carta
            // 
            btn_pegar_carta.Location = new Point(342, 378);
            btn_pegar_carta.Name = "btn_pegar_carta";
            btn_pegar_carta.Size = new Size(106, 38);
            btn_pegar_carta.TabIndex = 5;
            btn_pegar_carta.Text = "Pegar Carta";
            btn_pegar_carta.UseVisualStyleBackColor = true;
            btn_pegar_carta.Click += btn_pegar_carta_Click;
            // 
            // img_carta_1
            // 
            img_carta_1.Image = Properties.Resources.cardback1;
            img_carta_1.Location = new Point(50, 28);
            img_carta_1.Name = "img_carta_1";
            img_carta_1.Size = new Size(150, 218);
            img_carta_1.SizeMode = PictureBoxSizeMode.StretchImage;
            img_carta_1.TabIndex = 6;
            img_carta_1.TabStop = false;
            // 
            // img_carta_2
            // 
            img_carta_2.Image = Properties.Resources.cardback1;
            img_carta_2.Location = new Point(401, 28);
            img_carta_2.Name = "img_carta_2";
            img_carta_2.Size = new Size(150, 218);
            img_carta_2.SizeMode = PictureBoxSizeMode.StretchImage;
            img_carta_2.TabIndex = 7;
            img_carta_2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            ClientSize = new Size(619, 461);
            Controls.Add(img_carta_2);
            Controls.Add(img_carta_1);
            Controls.Add(btn_pegar_carta);
            Controls.Add(btn_passar_vez);
            Controls.Add(lbl_pontos_2);
            Controls.Add(lbl_carta_2);
            Controls.Add(lbl_pontos_1);
            Controls.Add(lbl_carta_1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Black Jack";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)img_carta_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_carta_2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_carta_1;
        private Label lbl_pontos_1;
        private Label lbl_carta_2;
        private Label lbl_pontos_2;
        private Button btn_passar_vez;
        private Button btn_pegar_carta;
        private PictureBox img_carta_1;
        private PictureBox img_carta_2;
    }
}
