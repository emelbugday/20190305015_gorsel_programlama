using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20190305015_EMEL_BUGDAY_CINEMA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        sinemaTableAdapters.Movie_InfoTableAdapter movie = new sinemaTableAdapters.Movie_InfoTableAdapter();
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                movie.AddMovie(textBox3.Text, comboBox2.Text, textBox4.Text);
                MessageBox.Show("Movie Added");
            }
            catch
            {
                MessageBox.Show("This movie has already been added, enter a differet movie");
            }


        }
    }
}
