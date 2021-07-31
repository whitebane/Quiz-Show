using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Show
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        int ttrue = 0;
        int ffalse = 0;
        string answer1 = "Z++";
        string answer2 = "MySql";
        string answer3 = "Console.Write";

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "Next";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            label6.Text = "20";
            sayac++;
            label8.Text = sayac.ToString();
            if (sayac==1)
            {
                timer1.Enabled = true;
                richTextBox1.Text = "Which one is not a programming language?";
                button1.Text = "C#";
                button2.Text = "Java";
                button3.Text = "Python";
                button4.Text = "Z++";
            }

            if (sayac==2)
            {
                timer1.Enabled = true;
                richTextBox1.Text = "Which one is a database";
                button1.Text = "MySql";
                button2.Text = "BaseTon";
                button3.Text = "Avaibles";
                button4.Text = "DataAcces";
            }

            if (sayac == 3)
            {
                timer1.Enabled = true;
                richTextBox1.Text = "Which one is prints to the screen in C#";
                button1.Text = "Console.Write";
                button2.Text = "PrintF";
                button3.Text = "Console.Read";
                button4.Text = "SystemOut";
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(label6.Text);
            a--;
            label6.Text = a.ToString();
            if (a.ToString()=="0")
            {
                timer1.Enabled = false;
                MessageBox.Show("Time's up!");
                ffalse++;
                label5.Text = ffalse.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text==answer1||button4.Text==answer2)
            {
                timer1.Enabled = false;
                MessageBox.Show("Congrats!!!");
                ttrue++;
                label4.Text = ttrue.ToString();
            }

           else if (button4.Text==answer3)
            {
                timer1.Enabled = false;
                MessageBox.Show("Congrats!!!");
                ttrue++;
                label4.Text = ttrue.ToString();
              
            }
            else
            {
                timer1.Enabled = false;
                MessageBox.Show("Wrong Answer!!");
                ffalse++;
                label5.Text = ffalse.ToString();
            }
            button2.Enabled = false;
            button3.Enabled = false;
            button1.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == answer1 || button1.Text == answer2)
            {

                timer1.Enabled = false;
                MessageBox.Show("Congrats!!!");
                ttrue++;
                label4.Text = ttrue.ToString();
            }
            else if (button1.Text == answer3)
            {
                timer1.Enabled = false;
                MessageBox.Show("Congrats!!!");
                ttrue++;
                label4.Text = ttrue.ToString();
         
            }

            else
            {
                timer1.Enabled = false;
                MessageBox.Show("Wrong Answer!!");
                ffalse++;
                label5.Text = ffalse.ToString();
            }


            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text==answer1||button2.Text==answer2)
            {
                timer1.Enabled = false;
                MessageBox.Show("Congrats!!!");
                ttrue++;
                label4.Text = ttrue.ToString();


            }

            else if (button2.Text == answer3)
            {
                timer1.Enabled = false;
                MessageBox.Show("Congrats!!!");
                ttrue++;
                label4.Text = ttrue.ToString();
             
            }

            else
            {
                timer1.Enabled = false;
                MessageBox.Show("Wrong Answer!!");
                ffalse++;
                label5.Text = ffalse.ToString();
            }
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == answer1 || button2.Text == answer2)
            {
                timer1.Enabled = false;
                MessageBox.Show("Congrats!!!");
                ttrue++;
                label4.Text = ttrue.ToString();


            }
            else if (button3.Text == answer3)
            {
                timer1.Enabled = false;
                MessageBox.Show("Congrats!!!");
                ttrue++;
                label4.Text = ttrue.ToString();
    
            }

            else
            {
                timer1.Enabled = false;
                MessageBox.Show("Wrong Answer!!");
                ffalse++;
                label5.Text = ffalse.ToString();
            }
            button2.Enabled = false;
            button1.Enabled = false;
            button4.Enabled = false;

        }
    }
}
