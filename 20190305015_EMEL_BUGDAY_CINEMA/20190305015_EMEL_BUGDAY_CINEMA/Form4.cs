using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20190305015_EMEL_BUGDAY_CINEMA
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        sinemaTableAdapters.Hall_InfoTableAdapter hall = new sinemaTableAdapters.Hall_InfoTableAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                hall.AddHall(textBox1.Text);
                MessageBox.Show("Hall Added");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("This hall has already been added, enter a differet hall name!");
            }
            textBox1.Text = "";

        }
    }
}
