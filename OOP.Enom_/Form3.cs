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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        [Flags] // aşağıdaki HasFlags komutunu kullanmak için gerekli
        public enum Roles
        {
            Admin,
            User,
            Moderatör,
            CEO,
            LocalUser,
            Guest,

            MasterAdmin =LocalUser| CEO | Admin
        }

        public class Personel
        {
            public string FullName { get; set; }
            public Roles Roles { get; set; }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Personel p = new Personel();
            p.FullName = "Sümeyye Kaya";
            p.Roles = Roles.LocalUser | Roles.Admin | Roles.CEO; //birkaç tane rol atadık

            var masterAdmin = Roles.LocalUser | Roles.CEO | Roles.Admin;

            var result = masterAdmin.HasFlag(p.Roles); //eğer masterAdmin içerisinde p.Roles'te tanımlanmış herhangi biri varsa master admin olarak sonuç verir. yani o üçden sadece biri varsa da olur.
            MessageBox.Show(result ? "Master Admin bir arkadaşımız" : "İşsiz bir arkadaşımız :(");

            //if (true)
            //{
            //    MessageBox.Show("Kullanıcının Adı : " + p.Roles.ToString());
            //}
            //else
            //{
            //    MessageBox.Show("Kullanıcının yetkisi yok");
            //}
            //MessageBox.Show(((Roles)p.Roles).ToString());
        }
    }
}
