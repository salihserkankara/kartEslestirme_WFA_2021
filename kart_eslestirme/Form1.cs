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
    public partial class Form1 : Form
    {
        int puan = 0;
        int ucDakika = 180, bir_saniye = 1;
        int seviye = 0;
        Surec surec;
        List<Button> butonlar;
        public Form1()
        {
            InitializeComponent();
            surec = new Surec();
            butonlar = new List<Button>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uc_dakika.Start();
            YeniSeviye();
        }

        private void TiklananKart(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text != "")
            {
                List<IslemKart> kartlar = surec.IslemKart2();
                int index = int.Parse(btn.Name.Substring(1));
                IslemKart src = surec.IslemKart2().FirstOrDefault(x => x.Seviye == seviye && x.Gosterim == true);
                IslemKart src2 = surec.IslemKart2().FirstOrDefault(x => x.Seviye == seviye && x.KartKonum == index);

                if (src == null)
                {
                    btn.Image = Image.FromFile(surec.IslemKart2().FirstOrDefault(x => x.Seviye == seviye && x.KartKonum == index).ResimAdi);
                    btn.Text = "";
                    surec.GosterimGuncelle(surec.IslemKart2().FindIndex(x => x.KartKonum == index && x.Seviye == seviye));
                }
                else
                {
                    Button btn2 = (Button)flp1.Controls.Find("b" + src.KartKonum, true)[0];
                    if (src.ResimAdi.Equals(src2.ResimAdi))
                    {
                        puan++;
                        label1.Text = Convert.ToString(puan);
                        dogru_mu_lbl.Text = "DOĞRU";
                        dogru_mu_lbl.ForeColor = Color.Green;
                        bir_saniye_tmr.Start();
                        surec.Tamamlandi(surec.IslemKart2().FindIndex(x => x.KartKonum == src2.KartKonum && x.Seviye == seviye), surec.IslemKart2().FindIndex(x => x.KartKonum == src.KartKonum && x.Seviye == seviye));
                        btn2.Enabled = false;
                        btn.Image = Image.FromFile(surec.IslemKart2().FirstOrDefault(x => x.Seviye == seviye && x.KartKonum == index).ResimAdi);
                        btn.Text = "";
                        btn.Enabled = false;
                        if (surec.IslemKart2().Where(x => x.Seviye == seviye && x.Tamamlandi).Count() == (seviye + 1) * 4)
                        {
                            if (surec.IslemKart2().Where(x => x.Seviye == seviye && x.Tamamlandi).Count() == 16)
                            {
                                uc_dakika.Stop();
                                //sonuç ekranı
                                Form2 frm = new Form2(surec.IslemKart2());
                                //frm.skor = puan;
                                frm.zaman = int.Parse(uc_dakika_lbl.Text);
                                frm.kazandi = "TEBRİKLER";
                                frm.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                YeniSeviye();
                            }
                        }
                    }
                    else
                    {
                        dogru_mu_lbl.Text = "YANLIŞ";
                        dogru_mu_lbl.ForeColor = Color.Red;
                        bir_saniye_tmr.Start();
                        surec.Tamamlanamadi(surec.IslemKart2().FindIndex(x => x.KartKonum == src2.KartKonum && x.Seviye == seviye), surec.IslemKart2().FindIndex(x => x.KartKonum == src.KartKonum && x.Seviye == seviye));
                        btn.Image = null;
                        btn.Text = "1";
                        btn2.Image = null;
                        btn2.Text = "1";
                    }
                }
            }
        }

        private void YeniSeviye()
        {
            surec.HepsiniFalseYap();
            butonlar.Clear();
            flp1.Controls.Clear();
            seviye++;
            for (int i = 0; i < surec.IslemKart2().Where(x => x.Seviye == seviye).OrderBy(x => x.KartKonum).Count(); i++)
            {
                Button btn = new Button
                {
                    Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2))),
                    Text = "1",
                    BackColor = System.Drawing.SystemColors.ActiveCaption,
                    BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                    FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                    Name = "b" + i,
                    Size = new System.Drawing.Size(134, 134)

                    //Image = Image.FromFile(surec.Seviye1Kartlar()[i].ResimAdi)
                };
                btn.Click += new System.EventHandler(this.TiklananKart);

                butonlar.Add(btn);
            }

            foreach (Button item in butonlar)
            {
                flp1.Controls.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bir_saniye_tmr_Tick(object sender, EventArgs e)
        {
            bir_saniye -= 1;
            if (bir_saniye == 0)
            {
                bir_saniye_tmr.Stop();
                dogru_mu_lbl.Text = "";
                dogru_mu_lbl.ForeColor = SystemColors.Control;
            }
        }

        private void uc_dakika_Tick(object sender, EventArgs e)
        {
            uc_dakika.Interval = 1000;
            ucDakika -= 1;
            uc_dakika_lbl.Text = Convert.ToString(ucDakika);
            if (ucDakika == 0)
            {
                uc_dakika.Stop();
                Form2 f = new Form2(surec.IslemKart2());
                f.kazandi = "ZAMAN DOLDU";
                //f.skor = Convert.ToInt32(label1.Text);
                f.zaman = 0;
                f.ShowDialog();
                this.Close();
            }
        }
    }
}
