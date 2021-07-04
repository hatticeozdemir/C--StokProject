using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stok
{
    public partial class kullanıcıekle : Form
    {
        public kullanıcıekle()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KSLE4AO\\SQLEXPRESS;Initial Catalog=STOK; Integrated Security=True;");
        SqlDataAdapter da;
        DataSet ds;
        DataClasses1DataContext db;
        SqlCommandBuilder cmdb;
        SqlCommand komut;

        private void kullanıcıekle_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        bool durum;
        void kontrol()
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("select * from Kullanıcı where  CONVERT(VARCHAR, KullanıcıAdi) ='" + textBox1.Text + "'", connection);
            komut.Parameters.AddWithValue("@KullanıcıAdi", textBox1.Text.ToString());
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            connection.Close();
        }
        private void btnkaydt_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                kontrol();
                if (durum == true)
                {
                    connection.Open();
                    string sorgu = "INSERT INTO Kullanıcı (KullanıcıAdi,KullanıcıParola) values (@KullanıcıAdi,@KullanıcıParola)";
                    komut = new SqlCommand(sorgu, connection);
                    komut.Parameters.AddWithValue("@KullanıcıAdi", textBox1.Text);
                    komut.Parameters.AddWithValue("@KullanıcıParola", textBox2.Text);
                    komut.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("KAYIT BAŞARI İLE EKLENDİ");
                    textBox1.Clear();
                    textBox2.Clear();
                    checkBox1.Checked = false;
                }
                else
                {
                    MessageBox.Show("Bu kayıt zaten mevcuttur.Kontrol edip tekrar deneyiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("LÜTFEN İŞLEMİNİZİ ONAYLAYINIZ.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            Form1 formCIKIS = new Form1();
            formCIKIS.Show();
            this.Hide();
        }
    }
}
