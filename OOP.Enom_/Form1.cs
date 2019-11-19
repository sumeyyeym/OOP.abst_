using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Enom_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(Enum.GetNames(typeof(Departman))); //getnames komutu ile enumda tanımlanan verileri alırız. addrange ile liste olarak cmb içine eklenir. typeof ile demek istediğimiz ise departman olarak belirlenen classta verdiğimiz type'ı kullan.
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
            p.Ad = textBox1.Text;
            p.Soyad = textBox2.Text;
            p.Departman = (Departman)Enum.Parse(typeof(Departman), comboBox1.Text); //burada demiş olduk ki, combobox içerisinden seçtiğimiz değeri departman içinde ara ve onu geri dön. ancak geri dönüş object olduğu için cast etmemiz gerekti.

            MessageBox.Show($@"
Personel Adı: {p.Ad}
Personel Soyadı: {p.Soyad}
Personel Departmanı: {p.Departman} "); //@ ile içerideki özel kullanımların öz niteliklerini kaybetmesine sebep olur

            listBox1.Items.Add(p);
            textBox1.Text = textBox2.Text = "";

            switch (p.Departman) //p.Departmanı yazdıktan sonra alt ok tuşuna tıklarsan case kısmı otomatik gelir
            {
                case Departman.Yazılım:
                    break;
                case Departman.Sistem:
                    break;
                case Departman.Grafik:
                    break;
                case Departman.Muhasebe:
                    break;
                case Departman.TeknikÇizim:
                    break;
                case Departman.Ofis:
                    break;
                default:
                    break;
            }
        }                
    }
}
