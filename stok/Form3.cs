using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AForge.Video;  
using AForge.Video.DirectShow;

namespace stok
{
    public partial class Form3 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KSLE4AO\\SQLEXPRESS;Initial Catalog=STOK; Integrated Security=True;");
        
        public Form3()
        {
            InitializeComponent();
           
        }
        public string a, b, c, d;
        
        SqlDataAdapter da;
        DataSet ds;
        DataClasses1DataContext db;
        SqlCommandBuilder cmdb;
        SqlCommand komut;
        
        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = a;
            textBox2.Text = b;
            textBox3.Text = c;
            textBox4.Text = d;
            DataTable table = new DataTable();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnstokdelete_Click(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked)
            {
                
                connection.Open();
                komut = new SqlCommand("DELETE FROM Stok_TelParca where CONVERT(VARCHAR, Stok_ParcaAdi) ='" + textBox1.Text + "'", connection);
                komut.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("İŞLEMİNİZ TAMAMLANDI");
                timer1.Start();
                timer1.Interval = 10;
                
            }
            else
            {
                MessageBox.Show("LÜTFEN İŞLEMİNİZİ ONAYLAYINIZ.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        bool durum;
        void kontrol()
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("select * from Stok_TelParca where  CONVERT(VARCHAR, Stok_ParcaAdi) ='" + textBox1.Text + "'", connection);
            komut.Parameters.AddWithValue("@Stok_ParcaAdi", textBox1.Text.ToString());
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            connection.Close();
        }
        private void btnstokadd_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                kontrol();
                if (durum == true)
                {
                    connection.Open();
                    string sorgu = "INSERT INTO Stok_TelParca (Stok_ParcaAdi,Stok_ParcaAdet,Stok_KayıtYapan,Stok_ModelID) values (@Stok_ParcaAdi,@Stok_ParcaAdet,@Stok_KayıtYapan,@Stok_ModelID)";
                    komut = new SqlCommand(sorgu, connection);
                    komut.Parameters.AddWithValue("@Stok_ParcaAdi", textBox1.Text);
                    komut.Parameters.AddWithValue("@Stok_ParcaAdet", textBox2.Text);
                    komut.Parameters.AddWithValue("@Stok_KayıtYapan", textBox3.Text);
                    komut.Parameters.AddWithValue("@Stok_ModelID", textBox4.Text);
                    komut.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("KAYIT BAŞARI İLE EKLENDİ");
                }
                else
                {
                    MessageBox.Show("Bu kayıt zaten mevcuttur.Kontrol edip tekrar deneyiniz.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("LÜTFEN İŞLEMİNİZİ ONAYLAYINIZ.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnstokupdate_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox4.Enabled = false;
            if (checkBox1.Checked)
            {
                    connection.Open();
                    string sorgu = "Update Stok_TelParca Set Stok_ParcaAdet=@Stok_ParcaAdet,Stok_KayıtYapan=@Stok_KayıtYapan Where CONVERT(VARCHAR, Stok_ParcaAdi) ='" + textBox1.Text + "'";
                    komut = new SqlCommand(sorgu, connection);
                    komut.Parameters.AddWithValue("@Stok_ParcaAdi", textBox1.Text);
                    komut.Parameters.AddWithValue("@Stok_ParcaAdet", textBox2.Text);
                    komut.Parameters.AddWithValue("@Stok_KayıtYapan", textBox3.Text);
                    
                    komut.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("KAYIT BAŞARI İLE GÜNCELLENDİ");
                
                
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

        private void btngeri_Click(object sender, EventArgs e)
        {

            Form4 formTEL = new Form4();
            formTEL.Show();
            this.Hide();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (timer1.Interval == 10)
            {
                
                Form4 formTEL = new Form4();
                formTEL.Show();
                this.Hide();
                timer1.Stop();
            }
            else
            {
                timer1.Enabled = false;
            }
        }
    }

}

