using System.Data.SqlClient;

namespace _20190305015_EMEL_BUGDAY_CINEMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BJ21RM9;Initial Catalog=ticket_sales;Integrated Security=True");

        int sayac = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            empty_seat();
            movieandhallget(comboBox2, "select *from Movie_Info", "MovieName");
            movieandhallget(comboBox3, "select *from Hall_Info", "HallName");
        }

        private void movieandhallget(ComboBox combo, string sql1, string sql2)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sql1, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read[sql2]);
            }
            baglanti.Close();
        }
        private void empty_seat()
        {
            sayac = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(30, 30);
                    btn.BackColor = Color.White;
                    btn.Location = new Point(j * 30 + 20, i * 30 + 30);
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    sayac++;
                    if (j == 4)
                    {
                        continue;
                    }
                    this.panel1.Controls.Add(btn);
                    btn.Click += btn_click1;
                }
            }
        }
        private void newcolor()
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.White;
                }
            }
        }

        private void combo_dolu()
        {
            foreach (Control item in panel1.Controls)
            {
                if (item.BackColor == Color.Black)
                {
                    comboBox1.Items.Add(item.Text);
                }
            }
        }
        private void full_seat()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Sales_Info where MovieName='" + comboBox2.SelectedItem + "'and HallName='" + comboBox3.Text + "'and Date='" + dateTimePicker1.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                foreach (Control item in panel1.Controls)
                {
                    if (item is Button)
                    {
                        item.BackColor = Color.Black;
                    }
                }
            }
            baglanti.Close();
        }
        private void btn_click1(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.BackColor == Color.White)
            {
                textBox1.Text = b.Text;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 fr5 = new Form5();
            fr5.ShowDialog();
        }
        sinemaTableAdapters.Sales_InfoTableAdapter sales = new sinemaTableAdapters.Sales_InfoTableAdapter();
        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tickets have been sold.");
            if (textBox1.Text != "")
            {
                try
                {
                    sales.AddSales(textBox1.Text, comboBox3.Text, comboBox2.Text, comboBox3.Text, dateTimePicker1.Text, comboBox5.Text, textBox2.Text, textBox3.Text, comboBox6.Text);
                }
                catch (Exception hata)
                {
                    MessageBox.Show("An error occurred while saving, please check the information!" + hata.Message);
                }
            }
            else
            {
                MessageBox.Show("You did not choose a seat!");
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            newcolor();
            full_seat();
        }
    }
}