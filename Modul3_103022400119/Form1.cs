namespace Modul3_103022400119
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmBxSatuanAwal.Text == "" && cmBxSatuanAkhir.Text == "")
            {
                MessageBox.Show("Pilih satuan Terlebih dahulu!");
            }
            if (textBoxNilaiAwal.Text == "" && textBoxNilaiAkhir.Text == "")
            {
                MessageBox.Show("Masukkan Angka Yang Valid!");
            }

            if (cmBxSatuanAwal.Text == "Celcius" && cmBxSatuanAkhir.Text == "Fahrenheit")
            {
                double cls = Convert.ToDouble(textBoxNilaiAwal.Text);
                double fahrenheit = cls + 32;
                textBoxNilaiAkhir.Text = fahrenheit.ToString();
            }
            else if (cmBxSatuanAwal.Text == "Fahrenheit" && cmBxSatuanAkhir.Text == "Celcius")
            {
                double fahrenheit = Convert.ToDouble(textBoxNilaiAwal.Text);
                double cls = fahrenheit - 32;
                textBoxNilaiAkhir.Text = cls.ToString();
            }
            else if (cmBxSatuanAwal.Text == "Reamur" && cmBxSatuanAkhir.Text == "Celcius")
            {
                double reamur = Convert.ToDouble(textBoxNilaiAwal.Text);
                double cls = 1.25 * reamur;
                textBoxNilaiAkhir.Text = cls.ToString();
            }
            else if (cmBxSatuanAwal.Text == "Celcius" && cmBxSatuanAkhir.Text == "Reamur")
            {
                double cls = Convert.ToDouble(textBoxNilaiAwal.Text);
                double reamur = 0.8 * cls;
                textBoxNilaiAkhir.Text = reamur.ToString();
            }
            else if (cmBxSatuanAwal.Text == "Fahrenheit" && cmBxSatuanAkhir.Text == "Reamur")
            {
                double fahrenheit = Convert.ToDouble(textBoxNilaiAwal.Text);
                double reamur = (4 / 9) * (fahrenheit - 32);
                textBoxNilaiAkhir.Text = reamur.ToString();
            }
            else if (cmBxSatuanAwal.Text == "Reamur" && cmBxSatuanAkhir.Text == "Fahrenheit")
            {
                double reamur = Convert.ToDouble(textBoxNilaiAwal.Text);
                double fahrenheit = (9 / 4) * reamur + 32;
                textBoxNilaiAkhir.Text = fahrenheit.ToString();
            } 
            else if (cmBxSatuanAwal.Text == "Celcius" && cmBxSatuanAkhir.Text == "Kelvin")
            {
                double cls = Convert.ToDouble(textBoxNilaiAwal.Text);
                double kelvin = cls + 273.15;
                textBoxNilaiAkhir.Text = kelvin.ToString();
            }
            else if (cmBxSatuanAwal.Text == "Kelvin" && cmBxSatuanAkhir.Text == "Celcius")
            {
                double kelvin = Convert.ToDouble(textBoxNilaiAwal.Text);
                double cls = kelvin - 273.15;
                textBoxNilaiAkhir.Text = cls.ToString();
            }
            else if (cmBxSatuanAwal.Text == "Fahrenheit" && cmBxSatuanAkhir.Text == "Kelvin")
            {
                double fahrenheit = Convert.ToDouble(textBoxNilaiAwal.Text);
                double kelvin = (5 / 9) * (fahrenheit - 32) + 273.15;
                textBoxNilaiAkhir.Text = kelvin.ToString();
            }
            else if (cmBxSatuanAwal.Text == "Kelvin" && cmBxSatuanAkhir.Text == "Fahrenheit")
            {
                double kelvin = Convert.ToDouble(textBoxNilaiAwal.Text);
                double fahrenheit = (9 / 5) * (kelvin - 273.15) + 32;
                textBoxNilaiAkhir.Text = fahrenheit.ToString();
            }
            else if (cmBxSatuanAwal.Text == "Reamur" && cmBxSatuanAkhir.Text == "Kelvin")
            {
                double reamur = Convert.ToDouble(textBoxNilaiAwal.Text);
                double kelvin = (5 / 4) * reamur + 273.15;
                textBoxNilaiAkhir.Text = kelvin.ToString();
            }
            else if (cmBxSatuanAwal.Text == "Kelvin" && cmBxSatuanAkhir.Text == "Reamur")
            {
                double kelvin = Convert.ToDouble(textBoxNilaiAwal.Text);
                double reamur = (4 / 5) * (kelvin - 273.15);
                textBoxNilaiAkhir.Text = reamur.ToString();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmBxSatuanAkhir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
