using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Çalar_Saat_v1._0
{
    public partial class Saat : Form
    {
        #region Değişkenler

        string dt2, sa2;
        int i = 0;
        int a = 0;
        #endregion

        public Saat()
        {
            InitializeComponent();
        }

        private void Saat_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.dt2;
            label2.Text = Form1.sa2;
            label3.Text = Form1.sa1;
            textBox1.Text = Form1.not;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dt2 = DateTime.Now.ToLongDateString();
            sa2 = DateTime.Now.ToLongTimeString();
            label1.Text = dt2;
            label2.Text = sa2;

            if (i%2==0)
            {
                label3.Location = new Point(73,50);
                i++;
            }

            else
            {
                label3.Location = new Point(80, 50);
                i++;
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (a==0)
            {
                button1.Text = "X";
                timer1.Stop();
                label3.Location = new Point(73, 50);
                a++;
            }

            else
            {
                this.Close();
            }
           
        }
    }
}
