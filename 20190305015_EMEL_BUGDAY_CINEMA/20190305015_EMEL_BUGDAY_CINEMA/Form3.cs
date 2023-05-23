using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20190305015_EMEL_BUGDAY_CINEMA
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BJ21RM9;Initial Catalog=ticket_sales;Integrated Security=True");
        private void MovieandHall(ComboBox combo, string sql, string sql2)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sql, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read() == true)
            {
                combo.Items.Add(read[sql2].ToString());
            }
            baglanti.Close();
        }

        string session = "";
        private void RadioButtonSeciliyse()
        {
            if (radioButton1.Checked == true) session = radioButton1.Text;
            else if (radioButton2.Checked == true) session = radioButton2.Text;
            else if (radioButton3.Checked == true) session = radioButton3.Text;
            else if (radioButton4.Checked == true) session = radioButton4.Text;
            else if (radioButton5.Checked == true) session = radioButton5.Text;
        }
        sinemaTableAdapters.Session_InfoTableAdapter movie_session = new sinemaTableAdapters.Session_InfoTableAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            RadioButtonSeciliyse();
            if (session != "")
            {
                movie_session.AddSession(comboBox1.Text, comboBox2.Text, dateTimePicker1.Text, session);
                MessageBox.Show("Session Added");
            }
            else if (session == "")
            {
                MessageBox.Show("You did not select a session!");
            }
            comboBox1.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();


        }

        private void Form3_Load(object sender, EventArgs e)
        {
            MovieandHall(comboBox1, "select *from Movie_Info", "moviename");
            MovieandHall(comboBox2, "select *from Hall_Info", "hallname");
        }
        private void tarih_karsilastir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Session_Info where hallname='" + comboBox1.Text + "'and date='" + dateTimePicker1.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read() == true)
            {
                foreach (Control item2 in groupBox1.Controls)
                {
                    if (read["session"].ToString() == item2.Text)
                    {
                        item2.Enabled = false;
                    }
                }
            }
            baglanti.Close();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime new1 = DateTime.Parse(dateTimePicker1.Text);
            if (new1 == today)
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if(DateTime.Parse(DateTime.Now.ToShortTimeString())>DateTime.Parse(item.Text))
                    {
                        item.Enabled = false;
                    }
                }
                tarih_karsilastir(); 
            }
            else if (new1>today)
            {
                tarih_karsilastir();
            }
            else if (new1<today)
            {
                MessageBox.Show("Cannot add session for past date");
            }
        }
    }
}
