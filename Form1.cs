using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arabaaClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        araba a = new araba();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            a.model = txtModel.Text;
            a.Plaka = txtPlaka.Text;
            a.Marka = txtMarka.Text;
            a.yil = timeYil.Value.Year;
            lstAraba.Items.Add(a.Marka+" "+a.model + " " +a.Plaka + " " +a.yil);



        }

        private void btnHizlan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hızınız="+a.Hizlan().ToString());
        }

        private void btnYavas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hızınız="+a.Yavasla().ToString()); 
        }
    }
}
