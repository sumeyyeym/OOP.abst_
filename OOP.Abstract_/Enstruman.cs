using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstract_
{
    public abstract class Enstruman //soyutlama işlemi. Eğer bir classın miras vermesini istiyor ancak nesne oluşturmak istemiyorsak bu komutu veriyoruz. Çünkü enstruman çok genel bir gruptur ve tek bir marka ya da açıklama vermek mümkün değildir. Bu sebeple içeriğinde pek çok alet için ortak başlıklar olmasına rağmen detaya girdiğimizde çeşitlenen bir grup. Bu sebeple de burada oluşturup aşağıda her class için mires verdik.
    {
        public string Marka { get; set; }
        public string Aciklama { get; set; }

        public abstract string Ses(); //virtual bize opsiyonellik sağlar. ancak biz bunun her alette kullanılmasını istiyoruz. bu sebeple zorunlu olarak kulanılıp override edilmesi iiçin abstract kullanırız.
        //{
        //    return "Enstruman Sesi";
        //} -- bu kısım abstractta çöp. çünkü bu kısmın yapılandırılması her miras alınan kısımda zorunlu olduğundan buraya değer atamaya gerek yok
    }

    public class Bateri : Enstruman { public override string Ses() { return "Bateri Sesi"; } }
    public class Keman : Enstruman { public override string Ses() { return "Keman Sesi"; } }
    public class Gitar : Enstruman { public override string Ses() { return "Gitar Sesi"; } }

    public class Muzisyen
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public Enstruman Enstruman { get; set; }
    }
}
