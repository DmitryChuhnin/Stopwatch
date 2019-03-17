using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //начальные значения
            label1.Text = "00";
            label2.Text = "00";
            label3.Text = "00";
            timer1.Interval = 1;
        }
        private int m, s, ms;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //форматирование данных индексатора m:s:ms
            if (ms == 99)
            {
                if (s == 59)
                {
                    if (m == 99)
                        m = 0;
                    else
                        m++;
                    s = 0;
                }
                else s++;
                ms = 0;
            }
            else ms++;
            //////////////////////////////////////////////////////////////////////////
            if (m.ToString().Length == 1)
                label1.Text = "0" + m.ToString();
            else
                label1.Text = m.ToString();
            if (s.ToString().Length == 1)
                label2.Text = "0" + s.ToString();
            else
                label2.Text = s.ToString();
            if (ms.ToString().Length == 1)
                label3.Text = "0" + ms.ToString();
            else
                label3.Text = ms.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)//если таймер уже включён
            {
                m = 0;
                s = 0;
                ms = 0;
                timer1.Enabled = false;
                button1.Text = "Start";
                button2.Enabled = true;
            }
            else 
            {
                //если таймер выключен
                timer1.Enabled = true;
                button1.Text = "Avast";
                button2.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Reset Button
            m = 0;
            s = 0;
            ms = 0;
            label1.Text = "00";
            label2.Text = "00";
            label3.Text = "00";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Text = "Resume";
            timer1.Enabled = false;
        }
    }
}
