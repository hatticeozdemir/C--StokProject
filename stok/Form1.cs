using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form2sec = new Form4();
            form2sec.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BilgisayarÜrünler form2sec = new BilgisayarÜrünler();
            form2sec.Show();
            this.Hide();
        }

        private void btnaksesuar_Click(object sender, EventArgs e)
        {
            
        }

        private void btndıscam_Click(object sender, EventArgs e)
        {
            frmtelefon Aksesuar = new frmtelefon();
            Aksesuar.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmtelefon form2sec = new frmtelefon();
            form2sec.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void kULLANICIEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
           kullanıcıekle form2sec = new kullanıcıekle();
            form2sec.Show();
            this.Hide();
        }

        private void kULLANICISİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullanıcıSil form2sec = new KullanıcıSil();
            form2sec.Show();
            this.Hide();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yARDIMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://social.msdn.microsoft.com/Forums/tr-TR/40d49ca8-ef32-43fa-b727-c7507cfabeed/c-yardm?forum=csharptr");
        }

        private void yARDIMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ayarlar form2sec = new ayarlar();
            form2sec.Show();
            this.Hide();
        }

        private void btnbarkod_Click(object sender, EventArgs e)
        {
            BarkodOkuyucu form2sec = new BarkodOkuyucu();
            form2sec.Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Aksesuar form2sec = new Aksesuar();
            form2sec.Show();
            this.Hide();

        }
    }
}
