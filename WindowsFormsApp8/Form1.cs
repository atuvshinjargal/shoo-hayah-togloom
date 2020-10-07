using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        int too = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a=rnd.Next(1,7);
            label1.Text = a.ToString();
            int onoo = Convert.ToInt32(label2.Text) + a;
            label2.Text = onoo.ToString();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 7);
            label1.Text = a.ToString();
            int onoo = Convert.ToInt32(label3.Text) + a;
            label3.Text = onoo.ToString();
            button1.Enabled = true;
            button2.Enabled = false;
            too++;
            if (too == 5)
            {
                int score1 = Convert.ToInt32(label2.Text);
                int score2 = Convert.ToInt32(label3.Text);
                if (score1<score2)
                {
                    MessageBox.Show("2-r toglogch yallaa.");
                }
                else
                {
                    if (score1 == score2)
                    {
                        MessageBox.Show("tenclee");
                    }
                    else
                    {
                        MessageBox.Show("1- r toglogch yallaa.");
                    }
                    
                }
                too = 0;
                label2.Text = "0";
                label3.Text = "0";
            }
        }
    }
}
