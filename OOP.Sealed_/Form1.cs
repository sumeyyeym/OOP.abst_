using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Sealed_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //ref tipler boş geçilebilir ama value tipler boş geçilemez.
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Personel p = new Personel();

            //value tipli bir değeri null olarak işaretlemek istiyorsak:

            int? a = null;

            // yada Nullable<DateTime>
        }

    }
}
