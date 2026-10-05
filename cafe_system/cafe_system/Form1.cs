namespace cafe_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double total;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Burger - 6.3");
            total += 6.3;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Tort - 4.5");
            total += 4.5;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Çay/Kofe - 3.0");
            total += 3.0;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Xot-doq - 3.5");
            total += 3.5;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Kokteyl - 5.0");
            total += 5.0;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Fri - 4.0");
            total += 4.0;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Pide/Tost - 7.0");
            total += 7.0;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Qazlı içki - 2.0");
            total += 2.0;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Toyuq - 8.5");
            total += 8.5;
        }

        // SƏBƏTDƏN SİL DÜYMƏSİ (button3)
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                // Seçilən yeməyin adını alırıq
                string yeyinti = listBox1.SelectedItem.ToString();

                // Qiymətini ümumi məbləğdən çıxırıq
                string[] hisseler = yeyinti.Split('-');
                if (hisseler.Length == 2)
                {
                    double qiymet = Convert.ToDouble(hisseler[1].Trim());
                    total -= qiymet;
                }

                // Səbətdən silirik
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                // Müəllimin tələb etdiyi bildiriş: “Yeməyin adı və səbətdən silindi”
                MessageBox.Show(yeyinti + " səbətdən silindi");
            }
        }

        // YENİLƏ DÜYMƏSİ (button4)
        private void button4_Click(object sender, EventArgs e)
        {
            // Müəllimin tələb etdiyi: "xanalar sıfırlansınmı?" bildirişi
            DialogResult cavab = MessageBox.Show("xanalar sıfırlansınmı?", "Bildiriş", MessageBoxButtons.YesNo);

            if (cavab == DialogResult.Yes)
            {
                listBox1.Items.Clear();
                textBox1.Text = "";
                textBox2.Text = "";
                label2.Text = "Qayıtarılır: 0";
                total = 0;
            }
        }

        // HESABLA / YEKUN HESAB DÜYMƏSİ (button5)
        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                // Müəllimin tələbi: “Səbətdə yemək yoxdur!” bildirişi
                MessageBox.Show("Səbətdə yemək yoxdur!");
            }
            else
            {
                textBox2.Text = total.ToString() + " AZN";
            }
        }

        // QALIQ HESAB DÜYMƏSİ (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double verilerPul = Convert.ToDouble(textBox1.Text);

                if (verilerPul >= total)
                {
                    double qaliq = verilerPul - total;
                    label2.Text = "Qayıtarılır: " + qaliq.ToString() + " AZN";
                }
                else
                {
                    // Müəllimin tələbi: “Daxil edilən məbləğ hesabdan azdır” bildirişi
                    MessageBox.Show("Daxil edilən məbləğ hesabdan azdır");
                }
            }
        }

        // TƏMİZLƏ DÜYMƏSİ (button2)
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "Qayıtarılır: 0";
        }
    }
}