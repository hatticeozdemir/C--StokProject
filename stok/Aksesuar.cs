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
using AForge.Video;
using AForge.Video.DirectShow;

namespace stok
{
    public partial class Aksesuar : Form
    {
        public Aksesuar()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KSLE4AO\\SQLEXPRESS;Initial Catalog=STOK; Integrated Security=True;");
        public string barkod { get; set; }
        private FilterInfoCollection webcam; 
        private VideoCaptureDevice cam;
        SqlDataAdapter da;
        DataSet ds;
        DataClasses1DataContext db;
        SqlCommandBuilder cmdb;
        SqlCommand komut;
        private void Aksesuar_Load(object sender, EventArgs e)
        {
            textBox1.Text = barkod;
            textBox1.Enabled = false;
            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo videocapturedevice in webcam)
            {
                comboBox1.Items.Add(videocapturedevice.Name);
            }
            comboBox1.SelectedIndex = 0;
            label4.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;
        }
        private void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bit;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cam = new VideoCaptureDevice(webcam[comboBox1.SelectedIndex].MonikerString);
            cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);
            cam.Start();
        }

        private void btnresmkaydet_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            label4.Text = dosyayolu;
            pictureBox1.ImageLocation = dosyayolu;
        }

        private void Aksesuar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cam.IsRunning)
            {
                cam.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if(textBox2.Text== string.Empty)
                {
                    MessageBox.Show("LÜTFEN AD ALANINI BOŞ BIRAKMAYINIZ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if(textBox1.Text==string.Empty)
                    {
                        DialogResult dialog = new DialogResult();
                        dialog = MessageBox.Show("Barkod no girilmemiş.Devam etmek istiyor musunuz?", "ÇIKIŞ", MessageBoxButtons.YesNo);
                        if (dialog == DialogResult.Yes)
                        {
                            
                            connection.Open();
                            string sorgu = "INSERT INTO Aksesuar (AksesuarBarkod,AksesuarAdi,AksesuarGörsel) values (@AksesuarBarkod,@AksesuarAdi,@AksesuarGörsel)";
                            komut = new SqlCommand(sorgu, connection);
                            komut.Parameters.AddWithValue("@AksesuarBarkod", textBox1.Text);
                            komut.Parameters.AddWithValue("@AksesuarAdi", textBox2.Text);
                            komut.Parameters.AddWithValue("@AksesuarGörsel", label4.Text);
                            komut.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("KAYIT BAŞARI İLE EKLENDİ");
                            textBox2.Clear();
                            
                        }
                        else
                        {
                            MessageBox.Show("Barkod okuyucu sayfasına dönüş yapınız.");
                        }
                    }
                    
                }
                
            }
            else
            {
                MessageBox.Show("LÜTFEN İŞLEMİNİZİ ONAYLAYINIZ.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 formTEL = new Form1();
            formTEL.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BarkodOkuyucu Aksesuar = new BarkodOkuyucu();
            Aksesuar.Show();
            this.Hide();
        }
    }
}
