using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diving_organizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin Admin_form = new Admin();
            Admin_form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Judge Judge_form = new Judge();
            Judge_form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ranking Ranking_from = new Ranking();
            Ranking_from.Show();
        }
    }

}
