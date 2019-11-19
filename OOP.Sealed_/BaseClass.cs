using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Sealed_
{
    public abstract class BaseClass
    {
        public BaseClass()
        {
            this.CreatedDate = DateTime.Now;
        }
        public DateTime CreatedDate { get; private set; } //bu şekilde yaparsak verinin girildiği vakit değiştirilemez. değişimi kısıtlama için set silinir ya da private hale getirilir. ya da direkt olarak prop da private hale getirilebilir.
        public DateTime ModifiedDate { get; set; }

        public virtual void SetLog() {  }
        public virtual void GetLog() {  }
        public virtual void GetCurrentUser() {  }

    }

    public class Personel : BaseClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return this.FirstName + " " + this.LastName; }
        }
        public sealed override void GetLog() //alt dallarada değiştirilmesi kısıtlanmış olur sealed ile. yalnızca buradan düzenlenir.
        {
            base.GetLog();
        }
        public sealed override void SetLog()
        {
            base.SetLog();
        }
        public sealed override void GetCurrentUser()
        {
            base.GetCurrentUser();
        }
    }

    public sealed class Yönetici : Personel
    {

    }

    //public class Temzilikçi : Yönetici -- buna kızar çünkü yönetici sealed hale getirildiği için miras verilemez. sealed yapılar yalnızca mira alabilir.
    //{

    //}
}
