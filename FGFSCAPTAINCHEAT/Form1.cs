using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cxapi;

namespace FGFSCAPTAINCHEAT
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Api.Attach();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Api.UserAgent("FGFS - captain Cheat", 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Api.IsRobloxOpen()){
                Api.KillRoblox();

            }
            else
            {
                MessageBox.Show("Roblox Not open");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Api.Execute(richTextBox1.Text);

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!");
        }
    }
}
