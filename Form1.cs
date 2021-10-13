using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev1
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int satis, fiyat, yenifiyat;
            fiyat = Convert.ToInt32(txtfiyat.Text);
            if (kdvbox.Checked == true && ogrencibox.Checked == false)
                {
                yenifiyat=fiyat + (fiyat * 18 / 100);
                satis=yenifiyat;
                txtsatis.Text = "" + satis;
                }
            else if (kdvbox.Checked == true && ogrencibox.Checked == true)
            {
                yenifiyat = fiyat - (fiyat * 5 / 100) + (fiyat*18/100);
                satis = yenifiyat;
                txtsatis.Text = "" + satis;
            }
            else if (kdvbox.Checked == false && ogrencibox.Checked == false)
            {
                satis = fiyat;
                txtsatis.Text = "" + satis;
            }
            else if (kdvbox.Checked == false && ogrencibox.Checked == true)
            {
                satis = fiyat - fiyat * 5 / 100;
                txtsatis.Text = "" + satis;
            }
            
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                
        }
    }
}
