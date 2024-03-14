namespace GUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            ilosc_przedmiotow = new TextBox();
            sseed = new TextBox();
            pojemnosc_plecaka = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            wynik1 = new TextBox();
            wynik2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(21, 192);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "START";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ilosc_przedmiotow
            // 
            ilosc_przedmiotow.BackColor = SystemColors.ActiveCaption;
            ilosc_przedmiotow.Location = new Point(21, 32);
            ilosc_przedmiotow.Name = "ilosc_przedmiotow";
            ilosc_przedmiotow.Size = new Size(67, 27);
            ilosc_przedmiotow.TabIndex = 0;
            // 
            // sseed
            // 
            sseed.BackColor = SystemColors.ActiveCaption;
            sseed.Location = new Point(21, 96);
            sseed.Name = "sseed";
            sseed.Size = new Size(67, 27);
            sseed.TabIndex = 1;
            // 
            // pojemnosc_plecaka
            // 
            pojemnosc_plecaka.BackColor = SystemColors.ActiveCaption;
            pojemnosc_plecaka.Location = new Point(21, 159);
            pojemnosc_plecaka.Name = "pojemnosc_plecaka";
            pojemnosc_plecaka.Size = new Size(67, 27);
            pojemnosc_plecaka.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.AppWorkspace;
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 3;
            label1.Text = "ilosc_przedmiotow";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.AppWorkspace;
            label2.Location = new Point(21, 73);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 4;
            label2.Text = "seed";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.AppWorkspace;
            label3.Location = new Point(21, 136);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 5;
            label3.Text = "pojemnosc_plecaka";
            // 
            // wynik1
            // 
            wynik1.Anchor = AnchorStyles.None;
            wynik1.BackColor = SystemColors.ActiveBorder;
            wynik1.ForeColor = SystemColors.WindowText;
            wynik1.Location = new Point(490, 15);
            wynik1.Multiline = true;
            wynik1.Name = "wynik1";
            wynik1.ReadOnly = true;
            wynik1.ScrollBars = ScrollBars.Vertical;
            wynik1.Size = new Size(178, 155);
            wynik1.TabIndex = 6;
            // 
            // wynik2
            // 
            wynik2.BackColor = SystemColors.ActiveBorder;
            wynik2.Location = new Point(21, 261);
            wynik2.Multiline = true;
            wynik2.Name = "wynik2";
            wynik2.ReadOnly = true;
            wynik2.ScrollBars = ScrollBars.Vertical;
            wynik2.Size = new Size(148, 140);
            wynik2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(699, 429);
            Controls.Add(wynik1);
            Controls.Add(wynik2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pojemnosc_plecaka);
            Controls.Add(sseed);
            Controls.Add(ilosc_przedmiotow);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox ilosc_przedmiotow;
        private TextBox sseed;
        private TextBox pojemnosc_plecaka;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox wynik1;
        private TextBox wynik2;
    }
}
