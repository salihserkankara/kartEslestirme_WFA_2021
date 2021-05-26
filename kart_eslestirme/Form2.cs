using kart_eslestirme.Modeller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kart_eslestirme
{
    public partial class Form2 : Form
    {
        
        public int zaman;
        public string kazandi;
        public List<IslemKart> islemKartlar;
        public Form2(List<IslemKart> model)
        {
            islemKartlar = model;
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            int skor = Convert.ToInt32(islemKartlar.Where(x => x.Tamamlandi).Count().ToString());
            //doğru sayısı buluyor
            //MessageBox.Show(islemKartlar.Where(x=>x.Tamamlandi).Count().ToString());
            label4.Text = Convert.ToString(skor / 2);
            if (zaman == 0)
                label1.Text = "ZAMAN DOLDU";
            else if (zaman != 0)
                label1.Text = "TEBRİKLER";
            else
                label1.Text = "hata";
            label3.Text = Convert.ToString(zaman);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            giris g = new giris();
            g.ShowDialog();
            this.Close();
        }
    }
}
