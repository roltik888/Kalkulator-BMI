namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Minimum = 10;
            progressBar1.Maximum = 40;
        }

        private void button_Click(object sender, EventArgs e)
        {
            string Wynik1 = "";
            double waga = 0;
            double wzrost = 0;
            double BMI = 0;
            if (double.TryParse(Textwg.Text, out waga))
            {
                if (double.TryParse(Textwz.Text, out wzrost))
                {
                    double wzrost1 = wzrost * wzrost;
                    BMI = waga / wzrost1;
                    if (BMI <= 18.5)
                    {
                        Wynik1 = "Niedowaga";
                    }
                    else if (BMI <= 24.9)
                    {
                        Wynik1 = "Wartość Prawidłowa";
                    }
                    else if (BMI <= 29.9)
                    {
                        Wynik1 = "Nadwaga";
                    }
                    else if (BMI <= 34.9)
                    {
                        Wynik1 = "Otyłość";
                    }
                    else if (BMI > 35)
                    {
                        Wynik1 = "Otyłość skrajna";
                    }
                    Wynik.Text = "Twoje BMI to: " + BMI.ToString("F2") + " - " + Wynik1;
                    int progressValue = (int)BMI;
                    if (progressValue < progressBar1.Minimum)
                    {
                        progressValue = progressBar1.Minimum;
                    }
                    else if (progressValue > progressBar1.Maximum)
                    {
                        progressValue = progressBar1.Maximum;
                    }
                    progressBar1.Value = progressValue;
                }
                else
                {
                    MessageBox.Show("Coś nie tak wpisane!");
                }
            }
            else
            {
                MessageBox.Show("Coś nie tak wpisane!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
