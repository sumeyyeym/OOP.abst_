using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Enom_
{

    //enum: sabitler. Haftanın günleri vs gibi değişmeyen, sabit değerler varsa bunları enum içerisinde kullanırız. En basit açıklaması bu. İlgili nesnenin veritabanındaki durumunu belirlemek için kullanıyoruz. Veritabanı yönetimi sağlanıyo. enumaın geri dönüş tipi inttir. veritabanındaki karşılıkları sayıdır.
    public enum Departman
    {
        Yazılım, Sistem, Grafik, Muhasebe, TeknikÇizim, Ofis
    }

    public class Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Departman Departman { get; set; } // istediğimiz veriyi giremeyelim diye kısıtlama getirmiş olduk

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();// bu daha performanslı bir yöntem
            stringBuilder.Append(this.Ad);
            stringBuilder.Append(" ");
            stringBuilder.Append(this.Soyad);
            return stringBuilder.ToString();

            /*return $"{Ad} {Soyad}";*/
        }
    }
}
