using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace MAKRO
{
    public partial class Form1 : Form
    {
        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(textBox2.Text);
            a++;
            label1.Text = a.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox4.Text!="" && textBox5.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;

                int surebir = Convert.ToInt32(textBox4.Text);
                int sureiki = Convert.ToInt32(textBox5.Text);
                int sureuc = 1000;
                timer1.Enabled = true;
                timer1.Interval = surebir;
                timer1.Start();

                timer2.Enabled = true;
                timer2.Interval = sureiki;
                timer2.Start();

                timer3.Enabled = true;
                timer3.Interval = sureuc;
                timer3.Start();

                button1.Enabled = false;
                button2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız");
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;

            timer1.Enabled = false;
            timer1.Stop();

            timer2.Enabled = false;
            timer2.Stop();

            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button1_Click(sender, e);
            }
            if (e.KeyCode == Keys.F2)
            {
                button2_Click(sender, e);
            }
        }
        int b=0;
        private void timer2_Tick(object sender, EventArgs e)
        {
                SendKeys.Send(textBox3.Text);            
                b++;
                label4.Text = a.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
      
        private void label9_Click(object sender, EventArgs e)
        {

        }
        int c = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {
            c++;
            label11.Text = c.ToString();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            c = 0;
            label11.Text = "0";
            timer3.Enabled = false;
            timer3.Stop();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
          
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
          
        }
    }
}
