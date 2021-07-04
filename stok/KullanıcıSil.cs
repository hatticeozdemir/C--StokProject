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
    public partial class KullanıcıSil : Form
    {
        public KullanıcıSil()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KSLE4AO\\SQLEXPRESS;Initial Catalog=STOK; Integrated Security=True;");

        void griddoldur()
        {
            da = new SqlDataAdapter("Select *From Kullanıcı", connection);
            ds = new DataSet();
            connection.Open();
            da.Fill(ds, "Kullanıcı");
            dataGridView1.DataSource = ds.Tables["Kullanıcı"];
            connection.Close();
        }
       
        private void btncikis_Click(object sender, EventArgs e)
        {
            Form1 formCIKIS = new Form1();
            formCIKIS.Show();
            this.Hide();
        }

        private void KullanıcıSil_Load(object sender, EventArgs e)
        {
            griddoldur();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        { if(checkBox1.Checked)
            {
                
                komut = new SqlCommand("DELETE FROM Kullanıcı where CONVERT(VARCHAR, KullanıcıAdi) ='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "'", connection);
                MessageBox.Show("İŞLEMİNİZ TAMAMLANDI");
                connection.Open();
                komut.ExecuteNonQuery();
                connection.Close();
                griddoldur();
            }
            else
            {
                MessageBox.Show("LÜTFEN İŞLEMİNİZİ ONAYLAYINIZ.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
