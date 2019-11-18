using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Abstract_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGitar_Click(object sender, EventArgs e)
        {
            Gitar gtr = new Gitar();
            gtr.Marka = "Yamaha";
            gtr.Aciklama = "Çok pahalı :')";

            Muzisyen mzs = new Muzisyen();
            mzs.Adi = "Müco";
            mzs.Soyadi = "Gitarsoy";
            mzs.Enstruman = gtr;

            MessageBox.Show(gtr.Ses());
        }

        private void BtnKeman_Click(object sender, EventArgs e)
        {
            Keman kmn = new Keman();
            kmn.Marka = "Stradivarius";
            kmn.Aciklama = "Bu da çok pahalı :')";

            Muzisyen mzs = new Muzisyen();
            mzs.Adi = "Müco";
            mzs.Soyadi = "Kemansoy";
            mzs.Enstruman = kmn;

            MessageBox.Show(kmn.Ses());
        }

        private void BtnBateri_Click(object sender, EventArgs e)
        {
            Bateri btr = new Bateri();
            btr.Marka = "Yamaha";
            btr.Aciklama = "Sorma işte, pahalı :')";

            Muzisyen mzs = new Muzisyen();
            mzs.Adi = "Müco";
            mzs.Soyadi = "Baterisoy";
            mzs.Enstruman = btr;

            MessageBox.Show(btr.Ses());
        }
    }
}
