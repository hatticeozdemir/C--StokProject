using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
namespace stok
{
    public partial class BarkodOkuyucu : Form
    {
        public BarkodOkuyucu()
        {
            InitializeComponent();
        }
        FilterInfoCollection Cihazlar;
        VideoCaptureDevice kameram;
        private void BarkodOkuyucu_Load(object sender, EventArgs e)
        {
            Cihazlar = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            
            foreach (FilterInfo cihaz in Cihazlar)
            {
                comboBox1.Items.Add(cihaz.Name);
            }
           
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kameram = new VideoCaptureDevice(Cihazlar[comboBox1.SelectedIndex].MonikerString);

            kameram.NewFrame += VideoCaptureDevice_NewFrame;
            kameram.Start();
        }
        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap GoruntulenenBarkod = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader okuyucu = new BarcodeReader();
            var sonuc = okuyucu.Decode(GoruntulenenBarkod);

            if (sonuc != null)
            {
                textBox1.Invoke(new MethodInvoker(delegate ()
                {
                   textBox1.Text = sonuc.ToString();
                }
                ));
            }

            pictureBox1.Image = GoruntulenenBarkod;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (kameram != null)
            {
                if (kameram.IsRunning)
                {
                    kameram.Stop();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form2sec = new Form1();
            form2sec.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == string.Empty)
            {
                MessageBox.Show("LÜTFEN BARKODU OKUTUNUZ.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                Aksesuar frm = new Aksesuar();
                frm.barkod = textBox1.Text;
                frm.Show();
                this.Hide();
            }
           
            
        }
    }
}
