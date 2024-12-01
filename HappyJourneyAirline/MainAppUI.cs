using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSample
{
    public partial class MainAppUI : Form
    {
        public MainAppUI()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            appTabs.SelectTab(3);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            appTabs.SelectTab(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            appTabs.SelectTab(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            appTabs.SelectTab(1);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            appTabs.SelectTab(1);
        }
    }
}
