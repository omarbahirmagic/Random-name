using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random_eded
{
    public partial class Form1 : Form
    {
        int num;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            num = r.Next(1, 100);
            button1.Enabled = true;
            textBox1.Enabled = true;
            textBox1.Clear();  
            textBox2.Clear();
            count = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
           
            
                if (a == num)
                {
                    count++;
                    textBox2.Text = "Siz düzgün tapdınız!\r\nCəhd sayı: " + count + "\r\nOyunu qazandınız!";
                }
                else if (a > num)
                {
                    count++;
                    textBox2.Text = "Siz yanlış tapdınız!\r\nCəhd sayı: " + count + "\r\nDaxil etdiyiniz ədəd gizli ədəddən böyükdür.";
                }
                else
                {
                    count++;
                    textBox2.Text = "Siz yanlış tapdınız!\r\nCəhd sayı: " + count + "\r\nDaxil etdiyiniz ədəd gizli ədəddən kiçikdir.";
                }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}