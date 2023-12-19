using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınavornek6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tiyatro tiyatro;
        List<Tiyatro> tiyatroListesi=new List<Tiyatro>();
        private void Form1_Load(object sender, EventArgs e)
        {
         tiyatroListesi.Add(new Tiyatro(1, "Cadı Kazanı", "2 saat 30 dakika", 100, new DateTime (2024,11,1), "Beylikdüzü Fatih Sultan Mehmet Kültür Sanat Merkezi Rasim Öztekin Sahnesi", true));
         tiyatroListesi.Add(new Tiyatro(2, "Fındıkkıran", "1 saat 20 dakika", 90, new DateTime(2023, 19, 12), "Beylikdüzü Fatih Sultan Mehmet Kültür Sanat Merkezi Rasim Öztekin Sahnesi", true));


        }
    }
}
