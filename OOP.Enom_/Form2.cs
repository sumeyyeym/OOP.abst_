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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public enum Sehirler //aslında görünmeyen bir ": int" var. yani intten miras almıştır ve int döner.
        {
            Ankara, //bunların aslında int karşılıkları vardır
            Edirne,
            İstanbul,
            Eskişehir,
            Adana,
        }
        public enum Cities : byte //byte'a çevirmiş olduk.
        {
            Ankara = 6, 
            Edirne = 22,
            İstanbul = 34,
            Eskişehir = 26,
            Adana = 1, //c#ta enumlarda yalnızca sayısal değer tutuyoruz. pytonda ise etinsel değer de tutmak mümkün
            //eğer sayısal değer verirken arada boşluklar bırakmış olsaydık en son değerden sonra bir artırarak devam ederdi. yani;
            /*
            Ankara = 6, 
            Edirne,
            İstanbul = 34

            şeklinde bırakmış olsaydık edirnenin değeri 7 olmuş olurdu otomatik olarak
            */

            //eğer enum içerisini tip veya veri açısından kalabalık yapacaksanız değer verme işini kendiniz yapmanız gerekebilir. küçük bir enum grubuyla uğraşılacaksa default olarak gelenleri kullanmak sıkıntı olmayacaktır.
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //string enumMetni = Sehirler.Adana.ToString(); //adana metnini verir
            //MessageBox.Show(enumMetni);

            //int enumDegeri = (int)Sehirler.Adana; //adananın enum içerisindeki index nosunu verir.
            //MessageBox.Show(enumDegeri.ToString());

            //byte citiesValue = (byte)Cities.Edirne;
            //MessageBox.Show(citiesValue.ToString());

            //enum sorgulama:

            if (Enum.IsDefined(typeof(Sehirler), "Edirne"))
            {
                MessageBox.Show("Enum değeri yer almaktadır");
            }
            else
            {
                MessageBox.Show("Enum değeri yer almamaktadır");
            }

            //eğer sayı değerini aratırsak ve enumda bir karşılığı varsa, karşılık olan değeri geri döner. yoksa, girilen sayıyı geri döner. Hata vermez. Ama yine de mantıksal bir hatası olmuş olur. Bunun önüne geçebilmek için eğer böyle bir enum değeri tanımlanmamışsa:

            int enumDegeri = 222;

            //Sehirler sehirler = (Sehirler)enumDegeri;
            //MessageBox.Show(sehirler.ToString()); --mantık hatası oluşur

            if (Enum.IsDefined(typeof(Sehirler), enumDegeri))
            {
                MessageBox.Show("Enum değeri yer almaktadır");
            }
            else
            {
                MessageBox.Show("Enum değeri yer almamaktadır");
            }
        }
    }
}
