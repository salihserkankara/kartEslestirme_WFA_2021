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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void basla_btn_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
            this.Close();
        }
    }
}
