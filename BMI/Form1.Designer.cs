namespace BMI
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
            Button button;
            Napiswz = new Label();
            Wynik = new Label();
            Napiswg = new Label();
            Textwz = new TextBox();
            Textwg = new TextBox();
            progressBar1 = new ProgressBar();
            button = new Button();
            SuspendLayout();
            // 
            // button
            // 
            button.Location = new Point(109, 80);
            button.Name = "button";
            button.Size = new Size(82, 23);
            button.TabIndex = 5;
            button.Text = "Oblicz BMI";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // Napiswz
            // 
            Napiswz.AutoSize = true;
            Napiswz.Location = new Point(12, 10);
            Napiswz.Name = "Napiswz";
            Napiswz.Size = new Size(65, 15);
            Napiswz.TabIndex = 0;
            Napiswz.Text = "Wzrost [m]";
            // 
            // Wynik
            // 
            Wynik.AutoSize = true;
            Wynik.Location = new Point(12, 107);
            Wynik.Name = "Wynik";
            Wynik.Size = new Size(0, 15);
            Wynik.TabIndex = 1;
            // 
            // Napiswg
            // 
            Napiswg.AutoSize = true;
            Napiswg.Location = new Point(190, 10);
            Napiswg.Name = "Napiswg";
            Napiswg.Size = new Size(61, 15);
            Napiswg.TabIndex = 2;
            Napiswg.Text = "Waga [kg]";
            // 
            // Textwz
            // 
            Textwz.Location = new Point(12, 37);
            Textwz.Name = "Textwz";
            Textwz.Size = new Size(100, 23);
            Textwz.TabIndex = 3;
            // 
            // Textwg
            // 
            Textwg.Location = new Point(190, 37);
            Textwg.Name = "Textwg";
            Textwg.Size = new Size(100, 23);
            Textwg.TabIndex = 4;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 136);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(278, 23);
            progressBar1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 169);
            Controls.Add(progressBar1);
            Controls.Add(button);
            Controls.Add(Textwg);
            Controls.Add(Textwz);
            Controls.Add(Napiswg);
            Controls.Add(Wynik);
            Controls.Add(Napiswz);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Napiswz;
        private Label Wynik;
        private Label Napiswg;
        private TextBox Textwz;
        private TextBox Textwg;
        private Button button;
        private ProgressBar progressBar1;
    }
}
