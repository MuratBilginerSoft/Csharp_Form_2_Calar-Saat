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
    public partial class Form1 : Form
    {
        #region Değişkenler

        public static string dt1, dt2,sa1,sa2,not;

        #endregion

        #region Tanımlamalar

        Saat nsaat = new Saat();
        #endregion



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt2 = DateTime.Now.ToLongDateString();
            sa2 = DateTime.Now.ToLongTimeString();
            label4.Text = dt2;
            label5.Text = sa2;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt1 =dateTimePicker1.Text;
            dt2 = DateTime.Now.ToLongDateString();
            sa1 = maskedTextBox1.Text;
            sa2 = DateTime.Now.ToLongTimeString();
            not = textBox1.Text;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dt2 = DateTime.Now.ToLongDateString();
            sa2 = DateTime.Now.ToLongTimeString();
            label4.Text = dt2;
            label5.Text = sa2;

            if (dt1== dt2 && sa1==sa2)
            {
                Saat nsaat = new Saat();
                timer1.Stop();
                this.Hide();
                nsaat.ShowDialog();
                this.Show();
            }

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
           
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
